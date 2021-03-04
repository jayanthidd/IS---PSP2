using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFdotnetframework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product p = new Product() { Description = "Eraser", Category = "Stationary" };
            ProductContext ctx = new ProductContext();
            ctx.Products.Add(p);
            ctx.SaveChanges();
            // At this point, if the program is being built for the first time, it will look for a data connection and 
            //if it cannot find one, it will create a database in the users folder of the c drive

            //server explorer from view
            //Data Connection
            // Find the file in the users folder in the c drive

            foreach(Product pdt in ctx.Products)
            {
                Console.WriteLine(pdt.Description + " : " + pdt.Category);
            }

            //filtering data
            IQueryable<Product> result = ctx.Products.Where(pr => pr.Description == "Eraser");

            //same as above
            var result2 =  ctx.Products.Where(pr => pr.Description == "Eraser");

            Console.WriteLine("All Erasers");
            foreach(var prod in result2)
            {
                Console.WriteLine($"Desc :  { prod.Description}");
            }

            // Select with the primary key
            var pdtwithpk = ctx.Products.Find(1);
            Console.WriteLine(pdtwithpk.Description);

            // DML - Update a record 
            //1. select the entity
            //2. update the content of the entity
            //3. save down the changes

            var pdttochange = ctx.Products.Find(2);
            pdttochange.Description = "Pencil";
            pdttochange.Category = "Stationary";
            ctx.SaveChanges();

            // DML - Delete a record 
            //1. select the entity
            //2. Remove the entity
            //3. save down the changes
            var pdttodelete = ctx.Products.Find(2);
            ctx.Products.Remove(pdttodelete);
            ctx.SaveChanges();
        }
            
    }
            
}
