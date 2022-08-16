using System;
using System.Collections.Generic;
//write program to check whether a number is even or odd
namespace myproject
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");
        }
    }
}
