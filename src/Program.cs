using System;
using System.Collections.Generic;
using ProductList.App.Strategies;

namespace ProductList.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1: List products by name.");
            Console.WriteLine("2: List products by cheapest.");
            Console.WriteLine("3: List products by newest.");
            Console.WriteLine("4: List products by availability.");
            Console.Write("Select product order:");

            var input = Console.ReadKey().Key;
            ISortingStrategy sortingStrategy = input switch
            {
                ConsoleKey.D1 => new NameAscendingStrategy(),
                ConsoleKey.D2 => new PriceAscendingStrategy(),
                ConsoleKey.D3 => new NewestFirstStrategy(),
                ConsoleKey.D4 => new AvailabilityStrategy(),
                _ => new NameAscendingStrategy()
            };

            var viewer = new ProductsViewer(InitProducts());
            var view = viewer.View(sortingStrategy);

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
