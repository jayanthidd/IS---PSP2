using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic delegates
            Func<int, int, int> calculationpointer;
            calculationpointer = Add;// dont call the function with the brackets
            int ergebnis = calculationpointer(10, 20);
            calcandprint(Add, 10, 20);
            calcandprint(Sub, 20, 10);

            calcandprint((a, b) => a + b, 5, 6);// the lambda expression is defining the function that will
            //be given as a program to the calcandprint method defined as a static method below
        }



        public static void calcandprint(Func<int, int, int> func, int a, int b)
        {
            int ergebnis = func(a, b);
            Console.WriteLine(ergebnis);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
