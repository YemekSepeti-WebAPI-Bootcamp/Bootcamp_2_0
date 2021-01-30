using Bootcamp.Extension.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bootcamp.Extension.TypedExtension
{
    public static class DiscountExtension
    {
        public static void ApllyBestSellerDiscount(this List<Product> products)
        {
            var bestSeller = products.OrderByDescending(p => p.SellCount).FirstOrDefault();
            bestSeller.DiscountedPrice = (bestSeller.Price * 10 / 100);

            ////var max = products.
            //var max = products.Max(p => p.SellCount);
            //products.FirstOrDefault(p => p.SellCount == max);
        }
    }
}
