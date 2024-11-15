using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Share.Consts;
using Web.Areas.Admin.ViewModels.AnswerVM;
using Web.Areas.Admin.ViewModels.ChapterVM;
using Web.Areas.Admin.ViewModels.QuestionVM;
using Web.Areas.Admin.ViewModels.SubjectVM;
using Web.Common;
using Web.WebConfig;
using X.PagedList;
using HtmlAgilityPack;

namespace Web.Areas.Admin.Controllers
{
    public class QuestionController : AdminBaseController
    {
        public QuestionController(GenericRepository repo, IMapper mapper) : base(repo, mapper)
        { }

        [AppAuthorize(AuthConst.AppQuestion.VIEW_DETAIL)]
        public async Task<IActionResult> Index() => View();


        [HttpGet]
        [Route("/Admin/Question/ListItem")]
        public IActionResult GetQuestion()
        {
            var data = _repo.GetAll<Question>()
                    .ProjectTo<ListQuestionVM>(AutoMapperProfile.QuestionIndexConf)
                    .ToList();
            return Ok(data);
        }

        [HttpGet]
        public async Task<IActionResult> GetSubject()
        {
            var model = new List<Subject>();

            var data = _repo.GetAll<Subject>()
                .ProjectTo<ListSubjectVM>(AutoMapperProfile.SubjectIndexConf).ToList();
            return Ok(data);
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
        public async Task<IActionResult> GetQuestionById(int id)
        {
            var question = await _repo.GetOneAsync<Question>(q => q.Id == id);
            if (question == null)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Không tìm thấy câu hỏi"
                });
            }

            var model = _mapper.Map<QuestionAddOrEditVM>(question);

            model.Options = _repo.GetAll<Answer>()
                .Where(a => a.QuestionId == question.Id)
                .ProjectTo<AnswerAddOrEdit>(AutoMapperProfile.AnswerIndexConf)
                .ToList();

            return Ok(model);
        }



        // add question
        [HttpPost]
        [Route("Admin/Question/CreateQuestion")]
        //[AppAuthorize(AuthConst.AppQuestion.CREATE)]
        public async Task<IActionResult> CreateQuestion([FromBody] QuestionAddOrEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Dữ liệu không hợp lệ"
                });
            }

            // Extract inner text from <p> tags
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(model.Content);
            var contentNode = htmlDoc.DocumentNode.SelectSingleNode("//p");
            var innerText = contentNode?.InnerText ?? model.Content;


            var question = _mapper.Map<Question>(model);

            question.answers = model.Options.Select((option, index) => new Answer
            {
                AnswerContent = option.AnswerContent,
                Status = option.Status,
                QuestionId = question.Id,
                CreatedBy = this.CurrentUserId,
                CreatedDate = DateTime.Now,
            }).ToList();

            question.CreatedBy = this.CurrentUserId;
            question.CreatedDate = DateTime.Now;

            await _repo.AddAsync(question);
            return Ok(new
            {
                success = true,
                message = "Thêm mới câu hỏi và câu trả lời thành công"
            });
        }

        //edit question
        [HttpPost]
        [AppAuthorize(AuthConst.AppQuestion.UPDATE)]
        public async Task<IActionResult> EditQuestion(int id, [FromBody] QuestionAddOrEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Dữ liệu không hợp lệ"
                });
            }

            var questionOld = await _repo.GetOneAsync<Question>(q => q.Id == id);
            if (questionOld == null)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Không tìm thấy câu hỏi"
                });
            }

            questionOld = _mapper.Map(model, questionOld);

            // Update existing answers
            // Lấy tất cả câu trả lời hiện có cho câu hỏi này
            var existingAnswers = _repo.GetAll<Answer>().Where(a => a.QuestionId == questionOld.Id).ToList();

            // Duyệt qua tất cả các option trong model để xử lý thêm mới hoặc cập nhật
            foreach (var option in model.Options)
            {
                var answer = existingAnswers.FirstOrDefault(a => a.Id == option.Id);
                if (answer != null)
                {
                    // Nếu tồn tại, cập nhật nội dung và trạng thái
                    answer.AnswerContent = option.AnswerContent;
                    answer.Status = option.Status;
                    answer.UpdatedBy = this.CurrentUserId;
                    answer.UpdatedDate = DateTime.Now;
                }

                //else
                //{
                //    var newAnswer = new Answer
                //    {
                //        AnswerContent = option.AnswerContent,
                //        Status = option.Status,
                //        QuestionId = questionOld.Id,
                //        CreatedBy = this.CurrentUserId,
                //        CreatedDate = DateTime.Now,
                //        UpdatedBy = this.CurrentUserId,
                //        UpdatedDate = DateTime.Now
                //    };
                //    questionOld.answers.Add(newAnswer);
                //}
            }

            // Xóa các câu trả lời không có trong model.Options
            var optionIds = model.Options.Select(o => o.Id).ToList();
            var answersToRemove = existingAnswers.Where(a => !optionIds.Contains(a.Id)).ToList();
            foreach (var answerToRemove in answersToRemove)
            {
                questionOld.answers.Remove(answerToRemove);
                // Thêm dòng này nếu muốn xóa luôn khỏi database
                await _repo.DeleteAsync(answerToRemove);
            }


            questionOld.UpdatedBy = this.CurrentUserId;
            questionOld.UpdatedDate = DateTime.Now;

            await _repo.UpdateAsync(questionOld);

            return Ok(new
            {
                success = true,
                message = "Cập nhật câu hỏi và câu trả lời thành công"
            });
        }

        [HttpPost]
        [AppAuthorize(AuthConst.AppQuestion.DELETE)]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var question = await _repo.GetOneAsync<Question>(q => q.Id == id);
            if (question == null)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "Không tìm thấy câu hỏi"
                });
            }

            await _repo.DeleteAsync(question);

            return Ok(new
            {
                success = true,
                message = "Xóa câu hỏi thành công"
            });
        }

    }
}
