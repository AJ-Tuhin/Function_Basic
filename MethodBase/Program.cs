using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Function();
            Console.WriteLine("I am main block.");
            Function();
            Console.WriteLine("i am main block again.");
            Function();
            Console.ReadKey();
        }

        static void Function()
        {
            Console.WriteLine("I am function !!");
        }
    }
}
