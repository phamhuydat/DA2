using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Migrations;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels.ClientExamVM;
using Web.WebConfig;

namespace Web.Controllers
{
    public class TestController : BaseController
    {
        public TestController(GenericRepository repo, IMapper mapper) : base(repo, mapper)
        {

        }

        public IActionResult ListTests()
        {
            return View();
        }

        public IActionResult Index() { return View(); }
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


        public IActionResult TakeExam(int id)
        {



            return View();
        }

    }
}
