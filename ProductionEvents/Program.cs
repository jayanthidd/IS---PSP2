using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductContainer pc = new ProductContainer();

            // now to add different subscriptions
            pc.OnAddingNewProduct += ProductAlarm;
            pc.OnAddingNewProduct += SMS;
            pc.OnAddingNewProduct += Newsletter;

            Product blouse = new Product() { Description = "Blouse", Price = 18 };
            pc.addNewProduct(blouse);

            pc.OnAddingNewProduct -= Newsletter;
            Product shoe = new Product() { Description = "Shoe", Price = 50 };
            pc.addNewProduct(shoe);

        }

        public static void ProductAlarm(string productdescription)
        {
            Console.WriteLine("A new product has been added : " + productdescription);
        }

        //Event-Handler, Callback-Methode
        public static void SMS(string productdescription)
        {
            Console.WriteLine("A new product has been added : " + productdescription);
        }
        //Event-Handler, Callback-Methode
        public static void Newsletter(string productdescription)
        {
            Console.WriteLine("A new product has been added : " + productdescription);
        }
    }
}
