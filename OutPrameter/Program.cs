using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPrameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 200;
            Console.WriteLine(a);
            Increse(out a);
            Console.WriteLine(a);

            Console.ReadKey();
        }

        static void Increse(out int a)
        {
            a = 100;
            Console.WriteLine(a);
        }

    }
}
