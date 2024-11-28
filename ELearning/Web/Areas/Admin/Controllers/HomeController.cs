using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Share.Consts;
using System.Drawing;
using Web.Areas.Admin.ViewModels.user;
using Web.Common;
using Web.WebConfig;

namespace Web.Areas.Admin.Controllers
{
	public class HomeController : AdminBaseController
	{

		public HomeController(GenericRepository repo, IMapper mapper) : base(repo, mapper)
		{

		}

		[AppAuthorize(AuthConst.AppGroup.VIEW_DETAIL)]
		public IActionResult Index()
		{
			var roleId = Convert.ToInt32(User.Claims.SingleOrDefault(c => c.Type.Contains(AppClaimTypes.RoleId))?.Value);
			if (roleId == AppConst.ROLE_CUSTOMER_ID)
			{
				return Redirect("/");
			}
			ViewBag.CountSubject = _repo.GetAll<Subject>().Count();
			ViewBag.CountQuestionActive = _repo.GetAll<Question>(s => s.DeletedDate == null).Count();
			ViewBag.CountUserUnBlock = _repo.GetAll<Users>(s => s.BlockedTo == null || s.BlockedTo < DateTime.Now).Count();
			ViewBag.CountGroup = _repo.GetAll<Group>().Count();
			return View();
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			return View(statusCode.ToString());
		}
	}
}
