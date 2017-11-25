using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3);
            Add(3,"4");
            Add(3,"4",5,6);
            Add(3,"4",5,6,7);
            Console.ReadKey();
        }

        static void Add(int a,string b =null,int c=0,int d=0,int e=0)
        {
            int f = a + Convert.ToInt32(b) + c + d + e;
            Console.WriteLine(f);
        }
    }
}
