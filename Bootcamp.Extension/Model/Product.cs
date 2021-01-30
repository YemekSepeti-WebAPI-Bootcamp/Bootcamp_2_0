using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp.Extension.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int SellCount { get; set; }
    }
}