using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Share.Consts;
using Web.Areas.Admin.ViewModels.ChapterVM;
using Web.Areas.Admin.ViewModels.ExamVM;
using Web.Areas.Admin.ViewModels.QuestionVM;
using Web.Areas.Admin.ViewModels.SubjectVM;
using Web.Common;
using Web.WebConfig;
using X.PagedList;

namespace Web.Areas.Admin.Controllers
{
	public class ExamController : AdminBaseController
	{
		protected readonly DataContext _db;

		public ExamController(DataContext db, GenericRepository repo, IMapper mapper) : base(repo, mapper)
		{
			_db = db;
		}

		// action view list exam
		[AppAuthorize(AuthConst.AppExam.VIEW_DETAIL)]
		public IActionResult Index(int page = 1, int size = 20)
		{
			var data = _repo.GetAll<Exam>()
						.ProjectTo<ListExamVM>(AutoMapperProfile.ExamIndexConf)
				.ToPagedList(page, size);
			return View(data);
		}

		// action view detail exam
		[AppAuthorize(AuthConst.AppExam.VIEW_DETAIL)]
		public IActionResult Detail(int id)
		{
			var data = _repo.FindAsync<Exam>(id).Result;
			return View(data);
		}

		// api list subject
		[HttpGet]
		public IActionResult GetSubject()
		{
			var model = new List<Subject>();

			var data = _repo.GetAll<Subject>()
				.ProjectTo<ListSubjectVM>(AutoMapperProfile.SubjectIndexConf).ToList();

			var mapData = data.Select(m => new
			{
				SubjectName = m.SubjectCode + " - " + m.SubjectName,
				SubjectCode = m.SubjectCode,
				Id = m.Id

			}).ToList();

			return Ok(mapData);
		}
		// api list chapter

		public IActionResult GetCountQuestion(int subjectId, int ChapterId, int level)
		{
			var data = _repo.GetAll<Question>()
				.Where(c => c.SubjectId == subjectId && c.ChapterId == ChapterId && c.Level == level)
				.Count();
			return Ok(data);
		}

		[HttpGet]
		public IActionResult GetChapter(int subjectId)
		{
			var data = _repo.GetAll<Chapter>()
				.Where(c => c.SubjectId == subjectId)
				.ProjectTo<ListChapterVM>(AutoMapperProfile.ChapterIndexConf)
				.ToList();
			return Ok(data);
		}
		// api list group
		[HttpGet]
		public IActionResult GetListGroup(int subjectId)
		{
			var data = _repo.GetAll<Group>()
				.Where(c => c.SubjectId == subjectId)
				.ToList();

			return Ok(data);
		}

		// action view create exam
		[HttpGet]
		[AppAuthorize(AuthConst.AppExam.CREATE)]
		public IActionResult CreateExam()
		{
			return View();

		}

		// action view edit exam
		[HttpGet]
		[AppAuthorize(AuthConst.AppExam.UPDATE)]
		public IActionResult EditExam(int id)
		{
			return View();
		}

		// get data update exam ro edit
		[HttpGet]
		public async Task<IActionResult> GetExam(int id)
		{
			var data = await _repo.GetOneAsync<Exam>(e => e.Id == id);

			var model = _mapper.Map<ExamAddOrEditVM>(data);

			var listGroup = _repo.GetAll<Group>()
				.Where(c => c.SubjectId == model.SubjectId)
				.ToList();
			return Ok(new { model, listGroup });
		}

		// action view add manual exam
		[HttpGet]
		[AppAuthorize(AuthConst.AppExam.CREATE)]
		public IActionResult AddManualExam(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var data = _repo.GetOneAsync<Exam>(e => e.Id == id).Result;
			if (data.IsAutomatic)
			{
				// trả về error http 403
				return Forbid();
			}
			return View();
		}

		// server create exam
		[HttpPost]
		[AppAuthorize(AuthConst.AppExam.CREATE)]
		public async Task<IActionResult> CreateExam([FromBody] ExamAddOrEditVM model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(new
				{
					success = false,
					message = "Dữ liệu không hợp lệ",
					data = model
				});
			}

			var exam = _mapper.Map<Exam>(model);
			exam.CreatedBy = CurrentUserId;
			exam.CreatedDate = DateTime.Now;
			exam.Status = true;

			await _repo.AddAsync(exam);
			// lấy ra dữ liệu mới được thêm vào của exam không có Id
			exam = await _repo.GetOneAsync<Exam>(e => e.Id == exam.Id);

			return Ok(new
			{
				success = true,
				message = "Tạo bài kiểm tra thành công",
				Data = exam
			});
		}

		// server get data exam
		[HttpGet]
		public async Task<IActionResult> GetDetailExam(int id)
		{
			try
			{
				// load list question to exam
				var exam = await _repo.GetOneAsync<Exam>(e => e.Id == id);

				var listQuestion = _repo.GetAll<Question>(x => x.SubjectId.Equals(exam.SubjectId))
					.ProjectTo<ListQuestionVM>(AutoMapperProfile.QuestionIndexConf)
					.ToList();
				var detailExam = _db.ExamDetails.Where(x => x.ExamId == id).OrderBy(x => x.DisplayOrder)
								.Join(_db.Question, ed => ed.QuestionId, q => q.Id, (ed, q) => new { q, ed })
								.Select(x => new ListQuestionVM
								{
									// Ánh xạ các thông tin từ câu hỏi
									Id = x.q.Id,
									Content = x.q.Content,
									SubjectId = x.q.SubjectId,
									ChapterId = x.q.ChapterId,
									Level = x.q.Level,
									// Ánh xạ danh sách câu trả lời (Options) cho từng câu hỏi
									Answers = _db.Answers
										.Where(a => a.QuestionId == x.q.Id && a.DeletedDate == null)
										.ToList() // Lọc các câu trả lời theo QuestionId

								}).ToList();

				return Ok(new { exam, listQuestion, detailExam });
			}
			catch (Exception ex)
			{
				return StatusCode(500, new { message = "An error occurred.", details = ex.Message });
			}
		}

		// server add ExamDetail
		[HttpPost]
		[AppAuthorize(AuthConst.AppExam.CREATE)]
		public async Task<IActionResult> SaveExamDetail(int id, [FromBody] List<ExamDetailsVM> model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(new
				{
					success = false,
					message = "Dữ liệu không hợp lệ",
					data = model
				});
			}

			var exam = await _repo.FindAsync<Exam>(id);

			if (exam is null)
			{
				return NotFound();
			}

			// Retrieve existing ExamDetails from the database
			var existingExamDetails = await _db.ExamDetails.Where(ed => ed.ExamId == id).ToListAsync();

			// Identify ExamDetails to delete
			var examDetailsToDelete = existingExamDetails
				.Where(ed => !model.Any(m => m.QuestionId == ed.QuestionId))
				.ToList();

			// Identify ExamDetails to add
			var examDetailsToAdd = model
				.Where(m => !existingExamDetails.Any(ed => ed.QuestionId == m.QuestionId))
				.Select(m => new ExamDetails
				{
					ExamId = id,
					QuestionId = m.QuestionId,
					DisplayOrder = m.DisplayOrder
				})
				.ToList();

			// Identify ExamDetails to update
			var examDetailsToUpdate = existingExamDetails
				.Where(ed => model.Any(m => m.QuestionId == ed.QuestionId))
				.ToList();

			// Update existing ExamDetails
			foreach (var examDetail in examDetailsToUpdate)
			{
				var updatedDetail = model.First(m => m.QuestionId == examDetail.QuestionId);
				examDetail.DisplayOrder = updatedDetail.DisplayOrder;
			}

			// Apply changes to the database
			_db.ExamDetails.RemoveRange(examDetailsToDelete);
			await _db.ExamDetails.AddRangeAsync(examDetailsToAdd);
			_db.ExamDetails.UpdateRange(examDetailsToUpdate);

			await _db.SaveChangesAsync();

			return Ok(new
			{
				success = true,
				message = "Cập nhật chi tiết bài kiểm tra thành công",
				data = model
			});
		}

		// Delete Exam    
		public async Task<IActionResult> DeleteExam(int id)
		{
			var data = _repo.GetOneAsync<Exam>(x => x.Id == id).Result;

			if (data == null)
			{
				return NotFound();
			}
			await _repo.DeleteAsync<Exam>(id);
			return RedirectToAction(nameof(Index));
		}




		// acton view detail exam
		[HttpGet]
		public IActionResult DetailExam(int id)
		{
			return View();
		}


		// mở bài thi

		public async Task<IActionResult> OpenExam(int id)
		{
			var exam = _repo.GetOneAsync<Exam>(x => x.Id == id).Result;
			if (exam == null)
			{
				return NotFound();
			}
			exam.TimeStart = DateTime.Now;

			await _repo.UpdateAsync(exam);

			return RedirectToAction(nameof(Index));
		}
	}
}
