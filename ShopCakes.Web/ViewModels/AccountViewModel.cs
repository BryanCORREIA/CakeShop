using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCakes.Web.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ShopCakes.Web.ViewModels
{
    public class AccountViewModel : IHaveCiviliteItems
    {
        [DisplayName("Civilité")]
        public int CiviliteId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public List<SelectListItem> CiviliteItems { get; set; }
    }
}
