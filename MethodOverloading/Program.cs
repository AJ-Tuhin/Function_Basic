using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = Add(5,6);
            int b = Add(5, 6, 7);
            int c = Add(5,6,7,8);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }

        static int Add(int a,int b)
        {
            int c = a + b;
            return c;

        }
        static int Add(int a, int b,int c)
        {
            int d = a + b+c;
            return d;
        }
        static int Add(int a, int b,int c,int d)
        {
            int e = a + b+c+d;
            return e;
        }

        //static int Add(int a, string b)
        //{
        //    int c = a + b;
        //    return c;
        //}
        //static int Add(string a, int b)
        //{
        //}
        //static int Add(string a, string b)
        //{
        //}

    }
}
