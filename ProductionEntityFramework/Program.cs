using System;

namespace ProductionEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product p1 = new Product() { Description = "Keyboard", Price = 50 };
            ProductContext ctx = new ProductContext();
            ctx.MyProducts.Add(p1);
            ctx.SaveChanges();
        }
    }
}
