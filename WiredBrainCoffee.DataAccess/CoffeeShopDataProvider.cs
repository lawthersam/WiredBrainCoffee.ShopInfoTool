using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansStockInKg = 107 };
            yield return new CoffeeShop { Location = "Freiburg", BeansStockInKg = 23 };
            yield return new CoffeeShop { Location = "Munich", BeansStockInKg = 56 };
        }
    }
}
