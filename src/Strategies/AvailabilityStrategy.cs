using System.Collections.Generic;
using System.Linq;

namespace ProductList.App.Strategies
{
    public class AvailabilityStrategy : ISortingStrategy
    {
        public List<Product> Sort(List<Product> products)
        {
            return products.OrderByDescending(p => p.AvailableStock).ToList();
        }
    }
}
