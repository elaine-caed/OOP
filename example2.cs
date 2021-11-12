using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Example2
    {
        static void Main()
        {
            double p = 3.14159;
            double x = 2.5;
            double y = Math.Cos(p * x) / (1 + x * x);
            Console.WriteLine();
            Console.WriteLine(" x = {0} \t y = {1}", x, y);
        }
    }
}
