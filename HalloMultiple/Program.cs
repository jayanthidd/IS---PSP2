using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello(Spanish, "F");
            SayHello(German, "F");
            SayHello(Spanish, "M");

            // without a staic method
            Greetinggenerator gg = new Greetinggenerator();

            SayHello(gg.polite, "F");

        }

        public static void SayHello(Greeting greeting, string gender)
        {
            string result = greeting(gender);
            Console.WriteLine(result);
        }

        public static string Spanish (string gender)
        {
            string result = "";
            if (gender == "F")
                result = "Hola Sinorita";
            else
            {
                result = "Hola Hombre";
            }
            return result;

        }
        public static string German(string gender)
        {
            string result = "";
            if (gender == "M")
                result = "Sehr geehrter Herr";
            else
            {
                result = "Sehr geehrte Frau";
            }
            return result;

        }
    }
}
