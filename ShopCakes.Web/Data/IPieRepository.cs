using System;
using System.Collections.Generic;
using ShopCakes.Web.Models;

namespace ShopCakes.Web.Data
{
    public interface IPieRepository
    {
        public IEnumerable<Pie> GetAllPies();

        public Pie GetPieById(int pieId);
    }
}
