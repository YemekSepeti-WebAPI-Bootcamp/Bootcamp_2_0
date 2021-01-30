using Bootcamp.Extension.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bootcamp.Extension.Mapper
{
    public static class MappingExtensions
    {
        public static List<Product> ToProducts(this List<ProductDTO> data)
        {
            return data.Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                DiscountedPrice = p.Price,
                SellCount = p.SellCount
            }).ToList();
        }

        public static List<ProductDTO> ToProductDTOs(this List<Product> data)
        {
            List<ProductDTO> resultItems = new List<ProductDTO>();
            foreach (var item in data)
            {
                resultItems.Add(new ProductDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    SellCount = item.SellCount
                });
            }
            return resultItems;
        }

    }
}
