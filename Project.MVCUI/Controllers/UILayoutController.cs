using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
