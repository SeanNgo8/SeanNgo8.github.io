﻿using Microsoft.AspNetCore.Mvc;

namespace Personal_Website.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
