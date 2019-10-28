using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCakes.Web.Data;
using ShopCakes.Web.Filters;
using ShopCakes.Web.ViewModels;

namespace ShopCakes.Web.Controllers
{
    [ServiceFilter(typeof(CiviliteItemsPopulator))]
    public class AccountController : Controller
    {
        public AccountController()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new AccountViewModel());
        }

        [HttpGet]
        public IActionResult Client()
        {
            return View(new ClientViewModel());
        }

        [HttpPost, LogFilter, ValidateModelState]
        //[ServiceFilter(typeof(LogFilter))]
        public IActionResult Index(AccountViewModel accountViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO SAVE Database
                return RedirectToAction("Index", "Home");
            }
            return View(accountViewModel);
        }
    }
}
