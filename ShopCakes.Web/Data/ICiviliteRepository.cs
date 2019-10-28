using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopCakes.Web.Models;

namespace ShopCakes.Web.Data
{
    public interface ICiviliteRepository
    {
        IEnumerable<Civilite> Get();
    }
   
}
