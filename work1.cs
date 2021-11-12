using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x =\r");
            double x = 
            Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(1.5 * x) - Math.Exp(Math.Sin((3 * x + 4)/3)) + Math.Pow(((6 * x + 7 )/ 6), 0.5);
            Console.WriteLine(" x = {0} \t y = {1}", x, y);
            Console.ReadLine();
        }
    }
}
