using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Simpleinterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of P:");
            double P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of T:");
            double T = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of R:");
            double R = int.Parse(Console.ReadLine());
            double simpleinterest = P * T * R / 100;
            Console.WriteLine("simple interest is:"+ simpleinterest);
        }
    }
}
