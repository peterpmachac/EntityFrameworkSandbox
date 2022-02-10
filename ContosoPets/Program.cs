// See https://aka.ms/new-console-template for more information


using ContosoPets.Data;
using ContosoPets.Models;

namespace ContosoPets
{
    class Program
    {
        static void Main(string[] args)
        {
            using ContosoPetsContext context = new ContosoPetsContext();

            // Add Products

            //context.Products.Add(new Product()
            //{
            //    Name = "Tennis Ball 3-Pack", Price = 9.99M
            //});
            //context.Products.Add(new Product()
            //{
            //    Name = "Squeaky Dog Bone",
            //    Price = 4.99M
            //});
            //context.SaveChanges();

            // Update Product
            var squeakyBone = context.Products
                                    .Where(p => p.Name == "Squeaky Dog Bone")
                                    .FirstOrDefault();

            if (squeakyBone is Product)
            {
                squeakyBone.Price = 7.99M;
                //context.Remove(squeakyBone);
            }
            context.SaveChanges();

            var products = context.Products
                .Where(p => p.Price >= 5.00M)
                .OrderBy(p => p.Price);

            //var products2 = from product in context.Products
            //                where product.Price > 5.00M
            //                orderby product.Name
            //                select product;

            foreach (Product product in products)
            {
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine(new String('-', 20));
            }
        }
    }
}



