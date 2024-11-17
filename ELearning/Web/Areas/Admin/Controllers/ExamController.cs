using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Web.Areas.Admin.ViewModels.ChapterVM;
using Web.Areas.Admin.ViewModels.SubjectVM;
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
        public async Task<IActionResult> GetSubject()
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
        public async Task<IActionResult> GetChapter(int subjectId)
        {
            var data = _repo.GetAll<Chapter>()
                .Where(c => c.SubjectId == subjectId)
                .ProjectTo<ListChapterVM>(AutoMapperProfile.ChapterIndexConf)
                .ToList();
            return Ok(data);
        }



        [HttpGet]
        public IActionResult CreateExam()
        {
            return View();
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
