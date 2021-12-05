using System.Collections.Generic;
using System.Linq;

namespace ProductList.App.Strategies
{
    public class NameAscendingStrategy : ISortingStrategy
    {
        public List<Product> Sort(List<Product> products)
        {
            return products.OrderBy(p => p.Name).ToList();
        }
    }
}
