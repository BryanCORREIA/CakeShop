using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCakes.Web.Filters
{
    public class LogFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var keyValuePair = context.ActionArguments.First();
            var model = keyValuePair.Value;

            var properties = model.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                if (!propertyInfo.Name.Contains("Items"))
                {
                    var value = GetValue(model, propertyInfo.Name);
                    Debug.Write($"{propertyInfo.Name} : {value} | ");
                }
            }
            Debug.WriteLine("");

            base.OnActionExecuting(context);
        }

        public static string GetValue(object item, string propName)
        {
            return item.GetType().GetProperty(propName)?.GetValue(item, null)?.ToString() ?? "";
        }
    }
}
