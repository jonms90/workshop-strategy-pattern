using System.Collections.Generic;

namespace ProductList.App.Strategies
{
    public interface ISortingStrategy
    {
        List<Product> Sort(List<Product> products);
    }
}
