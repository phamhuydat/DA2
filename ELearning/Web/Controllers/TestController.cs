using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Data.Entities;
using Data.Repositories;
using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels.ClientExamVM;
using Web.ViewModels.QuestionExamVM;
using Web.WebConfig;
using Microsoft.EntityFrameworkCore;

namespace Web.Controllers
{
	public class TestController : BaseController
	{
		public readonly DataContext _db;
		public TestController(DataContext db, GenericRepository repo, IMapper mapper) : base(repo, mapper)
		{
			_db = db;
		}

		public IActionResult ListTests()
		{
			return View();
		}

		public IActionResult Index() { return View(); }

		[HttpGet]
		public async Task<IActionResult> StartTest(int id)
		{
			var exam = await _repo.GetOneAsync<Exam>(x => x.Id == id);
			var subject = await _repo.GetOneAsync<Subject>(x => x.Id == exam.SubjectId);

			if (exam == null)
			{
				return NotFound();
			}

			var data = new ListExamUserVM
			{
				Id = exam.Id,
				StartTime = exam.TimeStart,
				EndTime = exam.TimeEnd,
				ExamName = exam.Title,
				WorkTime = exam.WorkTime,
				SubjectName = subject.SubjectCode + " - " + subject.SubjectName,
			};

			return View(data);
		}

		// lấy toàn bộ các bài thi của người dùng ở trong các nhóm học phần đang hoạt động
		public IActionResult LoadListExam()
		{
			// lây các bài thi của người dùng ở trong các nhóm học phần đang hoạt động và được phát bài thi ở handoutexam
			var listExam = _repo.GetAll<Exam>(
				x => x.DeletedDate == null
				&& x.handOutExams.Any(he =>
				he.group.GroupDetails.Any(y => y.UserId == this.CurrentUserId)))
				.ProjectTo<ListExamUserVM>(AutoMapperProfile.ExamIndexClientConf)
				.ToList();

			return Ok(listExam);
		}


		public async Task<IActionResult> ExamDetail(int id)
		{
			var exam = await _repo.GetOneAsync<Exam>(x => x.Id == id);
			var subject = await _repo.GetOneAsync<Subject>(x => x.Id == exam.SubjectId);

			if (exam == null)
			{
				return NotFound();
			}

			var data = new ListExamUserVM
			{
				Id = exam.Id,
				StartTime = exam.TimeStart,
				EndTime = exam.TimeEnd,
				ExamName = exam.Title,
				WorkTime = exam.WorkTime,
				SubjectName = subject.SubjectCode + " - " + subject.SubjectName,
			};

			return View(data);
		}

		[HttpGet]
		public async Task<IActionResult> TakeExam(int id)
		{
			var data = await _repo.GetOneAsync<Exam>(x => x.Id == id);

			// check bài thi có tồn tại không
			//if (data == null || data.TimeStart < DateTime.Now || data.TimeEnd > DateTime.Now)
			//{
			//    return NotFound();
			//}
			//else
			//{
			//    return View();
			//}

			return View();

		}

		//view bài thi
		[HttpGet]
		public async Task<IActionResult> TakeExamServer(int id)
		{
			var exam = await _repo.GetOneAsync<Exam>(x => x.Id == id);

			if (exam == null)
			{
				return NotFound();
			}

			List<ResQuestionVM> questions = new List<ResQuestionVM>();

			if (exam.IsAutomatic == false)
			{
				questions = _db.ExamDetails
					.Where(x => x.ExamId == id)
					.Select(x => new ResQuestionVM
					{
						Id = x.QuestionId,
						Content = x.Question.Content,
						answers = x.Question.answers.Select(a => new Answer
						{
							AnswerContent = a.AnswerContent,
						}).ToList()
					}).ToList();
			}
			else
			{
				// Fetch the chapters associated with the exam
				var chapters = _db.AutomaticExam
					.Where(ae => ae.ExamId == id)
					.Select(ae => ae.ChapterId)
					.ToList();

				// Fetch the number of questions required for each level
				var questionLevels = new Dictionary<int, int>
				{
					{ 1, exam.EQCount },
					{ 2, exam.MQCount },
					{ 3, exam.HQCount }
				};

				foreach (var level in questionLevels.Keys)
				{
					var levelQuestions = _db.Question
						.Where(q => chapters.Contains(q.ChapterId) && q.Level == level)
						.OrderBy(q => Guid.NewGuid())
						.Take(questionLevels[level])
						.Select(q => new ResQuestionVM
						{
							Id = q.Id,
							Content = q.Content,
							answers = q.answers.Select(a => new Answer
							{
								AnswerContent = a.AnswerContent,
							}).ToList()
						}).ToList();

					questions.AddRange(levelQuestions);
				}
			}

			// Check if a result already exists
			var check = await _repo.GetOneAsync<Result>(x => x.ExamId == id && x.UserId == this.CurrentUserId);

			if (check == null)
			{
				// Save result details
				var result = new Result
				{
					ExamId = exam.Id,
					UserId = this.CurrentUserId,
					StartTime = DateTime.Now
				};

				try
				{
					await _repo.AddAsync(result);
				}
				catch (Exception ex)
				{
					Console.Error.WriteLine($"Error adding result: {ex.Message}");
					return StatusCode(500, "An error occurred while saving the result.");
				}

				foreach (var question in questions)
				{
					var resultDetail = new ResultDetails
					{
						ResultId = result.Id,
						QuestionId = question.Id
					};
					try
					{
						await _repo.AddAsync(resultDetail);
					}
					catch (Exception ex)
					{
						Console.Error.WriteLine($"Error adding result detail: {ex.Message}");
						return StatusCode(500, "An error occurred while saving the result details.");
					}
				}
			}

			var examVM = new ExamDetailsVM
			{
				Id = exam.Id,
				UserName = this.CurrentUserName,
				WorkTime = exam.WorkTime,
				StartTime = check == null ? DateTime.Now : check.StartTime,
			};

			return Ok(new { examVM, questions });
		}

	}
}
