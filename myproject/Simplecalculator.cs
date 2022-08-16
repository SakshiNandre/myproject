using System;
using System.Collections.Generic;
using System.Text;
//Write a program to create Simple Calculator .
namespace myproject
{
    class Simplecalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for addition, press 2 for substraction, press 3 for multiplication, press 4 for division");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num 1:");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            switch(input)
            {
                case 1:
                 double addition=  num1 + num2;
                    Console.WriteLine("addition is:" + addition);
                    break;
                case 2:
                    double subtraction = num1 - num2;
                    Console.WriteLine("substraction is:" + subtraction);
                    break;
                case 3:
                    double multiplication = num1 * num2;
                    Console.WriteLine("multiplication is:" + multiplication);
                    break;
                case 4:
                    double division = num1 / num2;
                    Console.WriteLine("division is:" + division);
                    break;
                default:
                    Console.WriteLine("INVALID INPUT TRY AGAIN");
                    break;
            }
        }
    }
}
