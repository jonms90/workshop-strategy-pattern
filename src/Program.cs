using System;
using System.Collections.Generic;

namespace ProductList.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProductsViewer viewer = new ProductsViewer(InitProducts());
            Console.WriteLine("Check out our awesome products below!\n");
            List<string> productView = viewer.View();
            foreach (string entry in productView)
            {
                Console.WriteLine(entry);
            }
        }

        private static List<Product> InitProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    AvailableStock = 5,
                    Name = "M Chad Tee",
                    Price = 14.99m,
                    Published = new DateTime(2021, 12, 01)
                },
                new Product
                {
                    AvailableStock = 16,
                    Name = "M Chad LS",
                    Price = 19.99m,
                    Published = new DateTime(2021, 12, 03)
                },
                new Product
                {
                    AvailableStock = 8,
                    Name = "M Axel Tee",
                    Price = 14.99m,
                    Published = new DateTime(2021, 12, 03)
                },
                new Product
                {
                    AvailableStock = 2,
                    Name = "M Stripe Tee",
                    Price = 14.99m,
                    Published = new DateTime(2021, 11, 11)
                },
                new Product
                {
                    AvailableStock = 0,
                    Name = "M Will LS",
                    Price = 24.99m,
                    Published = new DateTime(2021, 12, 01)
                },
                new Product
                {
                    AvailableStock = 25,
                    Name = "M Silas Tee",
                    Price = 14.99m,
                    Published = new DateTime(2021, 12, 04)
                },
                new Product
                {
                    AvailableStock = 12,
                    Name = "Linen blend jacket",
                    Price = 59.99m,
                    Published = new DateTime(2021, 11, 06)
                },
                new Product
                {
                    AvailableStock = 6,
                    Name = "Corduroy overshirt",
                    Price = 49.99m,
                    Published = new DateTime(2021, 11, 09)
                },
            };
        }
    }
}
