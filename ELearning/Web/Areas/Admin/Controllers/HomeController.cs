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

        public IActionResult Index()
        {

            return View();
        }
    }
}
