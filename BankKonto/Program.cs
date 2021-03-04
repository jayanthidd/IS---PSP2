using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKonto
{
    class Program
    {
        static void Main(string[] args)
        {
            BankKonto k1 = new BankKonto() { accountholder = "Jayanthi" };
            BankKonto k2 = new BankKonto() { accountholder = "Dhanaraj" };
            k1.onGreaterthan1000 += K1_onGreaterthan1000;
            k2.onGreaterthan1000 += k2_onGreaterthan1000;

            k1.Accountbalance = 500;
            k1.Accountbalance = 1500;
            k2.Accountbalance = 1700;
        }
        private static void k2_onGreaterthan1000(object arg1, KontoEventargs e)
        {
            Console.WriteLine($"neuer Kontoastnand {e.newAccountBalance}");
            Console.Beep(5000, 1000);
        }

        private static void K1_onGreaterthan1000(object arg1, KontoEventargs e)
        {
            Console.WriteLine($"neuer Kontoastnand {e.newAccountBalance}");
            Console.WriteLine("Time for shopping");
        }
    }
}
