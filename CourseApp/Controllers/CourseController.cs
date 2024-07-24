﻿using Microsoft.AspNetCore.Mvc;
using CourseApp.Models;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            return View();
        }
    }
}
