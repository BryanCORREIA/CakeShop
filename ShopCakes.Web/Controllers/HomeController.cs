using System;
using Microsoft.AspNetCore.Mvc;
using ShopCakes.Web.Data;

namespace ShopCakes.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;


        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies();
            return View(pies);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            return View(pie);
        }
    }
}
