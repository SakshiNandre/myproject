using System;
using System.Collections.Generic;
using System.Text;
//Write a program to enter number between 1to 5 and print it in word
namespace myproject
{
    class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no between 1 to 5:");
            string num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("no should be between 1 to 5");
                    break;
            }

        }
    }
}