using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Share.Consts;
using Web.Areas.Admin.ViewModels.QuestionVM;
using Web.Common;
using Web.WebConfig;
using X.PagedList;

namespace Web.Areas.Admin.Controllers
{
    public class QuestionController : AdminBaseController
    {
        public QuestionController(GenericRepository repo, IMapper mapper) : base(repo, mapper)
        { }

        [AppAuthorize(AuthConst.AppQuestion.VIEW_DETAIL)]
        public async Task<IActionResult> Index(int page = 10, int size = 25)
        {
            var data = await _repo
                .GetAll<Question>()
                .ProjectTo<ListQuestionVM>(AutoMapperProfile.QuestionIndexConf)
                .ToPagedListAsync(page, size);

            return View(data);
        }
    }
}
