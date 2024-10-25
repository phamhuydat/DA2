using AutoMapper;
using Data.Repositories;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using System.Security.Cryptography;
using Web.Models;
using Web.WebConfig;

namespace Web.Controllers
{
    //[Authorize(AuthenticationSchemes = AppConst.CLIENT_COOKIES_AUTH)]
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;
        protected readonly GenericRepository _repository;
        protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
        private readonly ILog _logger;
        protected readonly string ADMIN = "admin";
        protected readonly string TEACHER = "teacher";
        protected readonly string STUDENT = "student";
        protected RedirectToActionResult AdminHomePage() => RedirectToAction("Index", "Home", new { area = "Admin" });

        public BaseController(GenericRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
        protected void SetErrorMesg(string mesg, bool modelStateIsInvalid = false)
        {
            TempData["Err"] = mesg;
            if (modelStateIsInvalid)
            {
                // hiển thị tin nhắn lỗi ở file log
                var invalidMesg = string.Join("\n", ModelState.Values
                                                .SelectMany(v => v.Errors)
                                                .Select(e => e.ErrorMessage));
                _logger.Error($"Model state is invalid: {invalidMesg}");
            }
        }
        protected void SetSuccessMesg(string mesg) => TempData["Messenger"] = mesg;

    }
}
