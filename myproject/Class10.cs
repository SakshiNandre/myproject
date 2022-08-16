using System;
using System.Collections.Generic;
using System.Text;
//WAP a program to check whether entered number is 3 digit or not .If it is a 3 digit no. then do sum of 1st and 3rd digit and print sum.
namespace myproject
{
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int i = int.Parse(Console.ReadLine());
            if (i >= 100 && i <= 999)
            {
                Console.WriteLine("entered number is 3 digit number");
                
            }

            else
            {
                Console.WriteLine("Entered number is not a 3 digit number");
                 }
        }
    }
}
