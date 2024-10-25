using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult ListTests()
        {
            return View();
        }

        public IActionResult Test() { return View(); }
        public IActionResult Exam() { return View(); }
    }
}
