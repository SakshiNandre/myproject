using System;
using System.Collections.Generic;
using System.Text;
//write a program to find maximum between 3 numbers
namespace myproject
{
    class Class3
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = 40;
            int c = 30;
            if ((a > b) && (a > c))
            {
                Console.WriteLine("a is the maximum one");
            }
            else if ((c > a) && (c > b))
                Console.WriteLine("c is maximum one");
            else
                Console.WriteLine("b is maximum");
        }
    }
}
