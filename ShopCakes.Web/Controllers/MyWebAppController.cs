using Microsoft.AspNetCore.Mvc;
using ShopCakes.Web.ActionResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCakes.Web.Controllers
{
    public class MyWebAppController : Controller
    {
        public IActionResult Xml(object model)
        {
            return new XmlResult(model);
        }
    }
}
