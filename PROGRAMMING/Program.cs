using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMMING
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Its value before displacement");
            Console.WriteLine("a ={0}", a);
            Console.WriteLine("b ={0}", b);


            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Its value after displacement");
            Console.WriteLine("a ={0}", a);
            Console.WriteLine("b ={0}", b);

            Console.ReadKey();
        }
    }
}
