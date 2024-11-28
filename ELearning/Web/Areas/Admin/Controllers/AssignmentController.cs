using Web.Areas.Admin.Controllers;
using AutoMapper;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    public class AssignmentController : AdminBaseController
    {
        public AssignmentController(GenericRepository repo, IMapper mapper) : base(repo, mapper)
        {

        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}
