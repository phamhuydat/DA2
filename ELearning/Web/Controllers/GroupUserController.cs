using AutoMapper;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class GroupUserController : BaseController
    {

        public GroupUserController(GenericRepository _repo, IMapper mapper) : base(_repo, mapper)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
