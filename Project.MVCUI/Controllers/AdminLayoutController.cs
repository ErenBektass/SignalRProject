﻿using Microsoft.AspNetCore.Mvc;

namespace Project.MVCUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
