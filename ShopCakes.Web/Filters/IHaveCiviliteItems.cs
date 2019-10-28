using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCakes.Web.Data;

namespace ShopCakes.Web.Filters
{
    public interface IHaveCiviliteItems
    {
        List<SelectListItem> CiviliteItems { get; set; }
    }

    public class CiviliteItemsPopulator : IActionFilter
    {
        private readonly ICiviliteRepository _civiliteRepository;

        public CiviliteItemsPopulator(ICiviliteRepository civiliteRepository)
        {
            _civiliteRepository = civiliteRepository;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var viewResult = context.Result as ViewResult;
            if (viewResult?.Model is IHaveCiviliteItems model)
            {
                var civilites = _civiliteRepository.Get().ToList();
                model.CiviliteItems = civilites
                    .Select(c =>
                        new SelectListItem
                        {
                            Text = c.Value,
                            Value = c.CiviliteId.ToString()
                        })
                    .ToList();
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {

        }
    }
}