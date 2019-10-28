using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCakes.Web.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCakes.Web.ViewModels
{
    public class ClientViewModel : IHaveCiviliteItems
    {
        public int CiviliteId { get; set; }

        public List<SelectListItem> CiviliteItems { get; set; }
    }
}
