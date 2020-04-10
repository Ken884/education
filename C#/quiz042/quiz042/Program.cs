using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz042
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>(){
                new Product() { Name = "お茶", Price = 88 },
                new Product() { Name = "おにぎり", Price = 100 },
                new Product() { Name = "菓子パン", Price = 152 },
                new Product() { Name = "サンドイッチ", Price = 250 },
                new Product() { Name = "タピオカミルクティー", Price = 2400 }

               
            };

            var taxIncludeProducts = products.Select(x => new { Name = x.Name, TaxIncludedPrice = Math.Truncate(x.Price * 1.1) });

            foreach(var product in taxIncludeProducts)
            {
                Console.WriteLine($"{product.Name}  {product.TaxIncludedPrice}円");
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
