﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCakes.Web.Filters;
using ShopCakes.Web.ViewModels;

namespace ShopCakes.Web.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [LogFilter]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(feedback);
            }
        }

    }
}
