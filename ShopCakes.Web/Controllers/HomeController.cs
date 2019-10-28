using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShopCakes.Web.ActionResults;
using ShopCakes.Web.Data;
using ShopCakes.Web.Models;

namespace ShopCakes.Web.Controllers
{
    public class HomeController : MyWebAppController
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        // GET
        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies();
            return View(pies);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View("Info", pie);
        }

        public IActionResult GetPiesXml()
        {
            var pies = _pieRepository.GetAllPies();
            return Xml(pies);
        }
    }
}
