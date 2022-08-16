using System;
using System.Collections.Generic;
using System.Text;
//Write a program that displays the day of the week corresponding to the number entered- 1 - "Monday", 2 -"Tuesday" and so on
namespace myproject
{
    class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            string day = Console.ReadLine();
            switch(day)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thrusday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error day does not exists");
                    break;
            }
        }
    }
}
