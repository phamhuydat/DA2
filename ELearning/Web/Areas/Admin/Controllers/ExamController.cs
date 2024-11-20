using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Share.Consts;
using Web.Areas.Admin.ViewModels.ChapterVM;
using Web.Areas.Admin.ViewModels.ExamVM;
using Web.Areas.Admin.ViewModels.SubjectVM;
using Web.Common;
using Web.WebConfig;

namespace Web.Areas.Admin.Controllers
{
    public class ExamController : AdminBaseController
    {
        public ExamController(GenericRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

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

        [HttpGet]
        public IActionResult GetChapter(int subjectId)
        {
            var data = _repo.GetAll<Chapter>()
                .Where(c => c.SubjectId == subjectId)
                .ProjectTo<ListChapterVM>(AutoMapperProfile.ChapterIndexConf)
                .ToList();
            return Ok(data);
        }

        [HttpGet]
        public IActionResult GetListGroup(int subjectId)
        {
            var data = _repo.GetAll<Group>()
                .Where(c => c.SubjectId == subjectId)
                .ToList();

            return Ok(data);
        }

        [HttpGet]
        [AppAuthorize(AuthConst.AppExam.CREATE)]
        public IActionResult CreateExam()
        {
            return View();
        }

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

        [HttpGet]
        [AppAuthorize(AuthConst.AppExam.CREATE)]
        public IActionResult AddManualExam()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetExam(int id)
        {
            var exam = await _repo.GetOneAsync<Exam>(e => e.Id == id);
            var examVM = _mapper.Map<ExamAddOrEditVM>(exam);
            return Ok(examVM);
        }
        [HttpGet]
        public async Task<IActionResult> GetDetailExam(int id)
        {
            // load list question to exam

            var exam = await _repo.GetOneAsync<Exam>(e => e.Id == id);
            var examVM = _mapper.Map<ExamAddOrEditVM>(exam);
            return Ok(examVM);
        }


        [HttpGet]
        public IActionResult EditExam(int id)
        {
            return View();
        }

        public IActionResult DeleteExam(int id)
        {
            return View();
        }

    }
}
