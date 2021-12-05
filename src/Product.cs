﻿using System;

namespace ProductList.App
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableStock { get; set; }
        public DateTime Published { get; set; }
    }
}
