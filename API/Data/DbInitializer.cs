using System.Net.WebSockets;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product> {
                new Product {
                    Name = "说话之道",
                    Description = "蔡康永之作",
                    Price = 10000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道2",
                    Description = "蔡康永之作",
                    Price = 11000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道3",
                    Description = "蔡康永之作",
                    Price = 12000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道4",
                    Description = "蔡康永之作",
                    Price = 14000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道5",
                    Description = "蔡康永之作",
                    Price = 15000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道6",
                    Description = "蔡康永之作",
                    Price = 16000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道7",
                    Description = "蔡康永之作",
                    Price = 17000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道8",
                    Description = "蔡康永之作",
                    Price = 18000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道9",
                    Description = "蔡康永之作",
                    Price = 19000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道10",
                    Description = "蔡康永之作",
                    Price = 20000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道11",
                    Description = "蔡康永之作",
                    Price = 21000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道12",
                    Description = "蔡康永之作",
                    Price = 22000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
                new Product {
                    Name = "说话之道13",
                    Description = "蔡康永之作",
                    Price = 23000,
                    PictureUrl = "",
                    Brand = "蔡康永",
                    Type = "心理学",
                    QuantityInStock = 100,
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}