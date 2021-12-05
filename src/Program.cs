using System;
using System.Collections.Generic;

namespace ProductList.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1: List products by name.");
            Console.WriteLine("2: List products by cheapest. (NOT IMPLEMENTED)");
            Console.WriteLine("3: List products by newest. (NOT IMPLEMENTED)");
            Console.WriteLine("4: List products by availability. (NOT IMPLEMENTED)");
            Console.Write("Select product order:");

            var sortOrder = Console.ReadKey().Key;
            var viewer = new ProductsViewer(InitProducts());
            var view = sortOrder switch
            {
                ConsoleKey.D1 => viewer.ViewByName(),
                ConsoleKey.D2 => viewer.ViewByCheapest(),
                ConsoleKey.D3 => viewer.ViewByNewest(),
                ConsoleKey.D4 => viewer.ViewByAvailability(),
                _ => viewer.ViewByName()
            };
            
            Console.WriteLine("\n\nCheck out our awesome products!\n");
            foreach (var entry in view)
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
