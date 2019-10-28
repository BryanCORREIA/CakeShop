using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopCakes.Web.Models;

namespace ShopCakes.Web.Data
{
    public class MockCiviliteRepository : ICiviliteRepository
    {
        public IEnumerable<Civilite> Get()
        { 
            yield return new Civilite {CiviliteId = 1, Value = "Mr" };
            yield return new Civilite {CiviliteId = 2, Value = "Mme" };
        }
    }
}
