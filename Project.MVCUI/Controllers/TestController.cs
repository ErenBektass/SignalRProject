using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
