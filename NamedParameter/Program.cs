using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(b:7,c:60);
            Console.ReadKey();
        }

        static void Add(int a=0,int b=0,int c=0,int d=0,int e=0)
        {
            //int f = b + c;
            int f = a + b + c + d + e;
            Console.WriteLine(f);
        }
    }
}
