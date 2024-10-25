using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Drawing;
using Web.Areas.Admin.ViewModels.user;
using Web.WebConfig;

namespace Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {

        public HomeController(GenericRepository repo, IMapper mapper) : base(repo, mapper)
        {

        }
        public async Task<IActionResult> Index(int page = 1, int size = 10)
        {

            return View();
        }
    }
}
