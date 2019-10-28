using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ShopCakes.Web.ActionResults
{
    public class XmlResult : ActionResult
    {
        private readonly object _data;

        public XmlResult(object data)
        {
            _data = data;
        }

        public override void ExecuteResult(ActionContext context)
        {
            var xmlSerializer = new XmlSerializer(_data.GetType());
            var response = context.HttpContext.Response;
            response.ContentType = "text/xml";
            base.ExecuteResult(context);
        }
    }
}
