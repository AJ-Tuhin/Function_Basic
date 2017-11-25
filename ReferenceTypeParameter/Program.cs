using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypeParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2000;
            Console.WriteLine(a);
            Increse(ref a);
            Console.WriteLine(a);
            Increse(ref a);
            Console.WriteLine(a);
            Console.ReadKey();
        }

        static void Increse(ref int a)
        {
            a += 100;
            Console.WriteLine(a);
        }
    }
}
