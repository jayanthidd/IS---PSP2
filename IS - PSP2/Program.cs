using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS___PSP2
{
    class Program
    {
        //return type and paramethers should be defined
        delegate int pointertomethod(int a, int b);
        static void Main(string[] args)
        {
             Math m = new Math();
            int result1 = m.Add(12, 5);
            // a dalegate is a variable in which a method address is saved
            // The variable should be the same type as the method
            pointertomethod p = m.Add;
            int result2 = p(12, 5);
            // the delegate can now point to another method with the same signature
        }
    }
}
