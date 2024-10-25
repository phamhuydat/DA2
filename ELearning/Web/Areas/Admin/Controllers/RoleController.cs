using App.Web.Areas.Admin.Controllers;
using AutoMapper;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class RoleController : AdminBaseController
    {
        public RoleController(GenericRepository repo, IMapper mapper) : base(repo, mapper) { }

        public IActionResult Index()
        {
            return View();
        }
    }
}
