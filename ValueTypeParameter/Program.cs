using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 200;
            Console.WriteLine(a);
            Increse(a);
            Console.WriteLine(a);

            Console.ReadKey();
        }

        static void Increse(int a)
        {
            a += 100;
            Console.WriteLine(a);
        }
    }
}
