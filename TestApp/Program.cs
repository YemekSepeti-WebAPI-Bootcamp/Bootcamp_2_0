using Bootcamp.Extension;
using Bootcamp.Extension.Mapper;
using Bootcamp.Extension.Model;
using Bootcamp.Extension.TypedExtension;
using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable1 = "Kodluyoruz";

            if (variable1.IsEmpty())
            {
            }


            if (variable1.IsFilled())
            {
            }
            if (string.IsNullOrWhiteSpace(variable1))
            {

            }

            int rangeValue = 5;
            int start = 2;
            int end = 20;

            var result = rangeValue.IsInRange(start, end);

            int productAmount = 10;
            var crossRatedAmount = productAmount.ConvertToCrossRate();

            TestObject obj1 = new TestObject() { Id = 1, Name = "soru" };
            obj1.ChangeValue();


            List<Product> productList = new List<Product>()
            {
                 new Product{ Id = 1, Name = "Phone", Price = 10000, DiscountedPrice = 10000, SellCount = 500 },
                 new Product{ Id = 1, Name = "TV", Price = 15000, DiscountedPrice = 15000, SellCount = 700 }
            };

            productList.ApllyBestSellerDiscount();

            List<Product> productItems = new List<Product>();
            productItems.Add(new Product { Id = 1, Name = "Phone", Price = 1500, DiscountedPrice = 1500, SellCount = 50 });
            productItems.Add(new Product { Id = 2, Name = "TV", Price = 1800, DiscountedPrice = 1800, SellCount = 100 });

            var newItems = productItems.ToProductDTOs();





            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
