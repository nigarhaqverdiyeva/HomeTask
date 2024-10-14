using System;

namespace _14102024_Class
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product
                {
                    Name = "Rice",
                    BrandName = "Tamasha",
                    Price = 23.4
                },
                new Product
                {
                    Name = "Apple",
                    BrandName = "Guba",
                    Price = 44
                }
            };

            double minPrice = 30.0;
            double maxPrice = 50.0;

            ProductMethod(products, minPrice, maxPrice);
        }

        static void ProductMethod(Product[] products, double minPrice, double maxPrice)
        {
            foreach (var product in products)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice)
                {
                    Console.WriteLine("Ad: " + product.Name);
                    Console.WriteLine("Qiymət: " + product.Price);
                }
            }
        }
    }
}
