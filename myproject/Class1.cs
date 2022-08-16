using System;
using System.Collections.Generic;
using System.Text; 
//write a program to check whether the year is leap year or not
namespace myproject
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year :");
            int Year = int.Parse(Console.ReadLine());
            if((Year%4==0 && Year%100!=0)||(Year%400==0))
            {
                Console.WriteLine("year is leap year");
            }
            else
            {
                Console.WriteLine("year is not a leap year");
            }
        }
    }
}
