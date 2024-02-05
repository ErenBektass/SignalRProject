using Microsoft.AspNetCore.Mvc;
using Project.DAL.Context;

namespace Project.MVCUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Index2()
        {

            return View();
        }
    }
}
