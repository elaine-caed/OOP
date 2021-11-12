using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The current date and time is " + System.DateTime.Now);
            double pi = 3.14159;
            Console.WriteLine("Input x =\r");
            double x = 
            Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(pi * x) / (1 + x * x);
            Console.WriteLine(" x = {0} \t y = {1}", x, y);
            Console.ReadLine();
        }
    }
}

