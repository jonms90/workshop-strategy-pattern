using System.Collections.Generic;
using System.Linq;

namespace ProductList.App
{
    public class ProductsViewer
    {
        private readonly List<Product> _products;

        public ProductsViewer(List<Product> products)
        {
            _products = products;
        }

        public List<string> View()
        {
            List<Product> products = GetProductsSortedByName();
            List<string> view = new List<string> { $"{"Name:",-20} {"Price:":C2} {"Stock:",5} {"Published:",-20:dd MMMM yyyy}" };
            view.AddRange(products.Select(p =>
                    $"{p.Name,-20} {p.Price:C2} {p.AvailableStock,5} {p.Published,20:dd MMMM yyyy}")
                .ToList());
            return view;
        }

        private List<Product> GetProductsSortedByName()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }
    }


}
