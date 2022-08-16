using System;
using System.Collections.Generic;
using System.Text;
//write code num is positive or negative
//write a code to check num is divisible by 5 or not
//write a code to check num is positive negative or zero 
namespace Assingnment1
{
    class Class14
    {
        static void Main(string[] args)
        {
            {//code to check num is divisible by 5 or not
                Console.WriteLine("Enter the num: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 5 == 0)
                    Console.WriteLine("num is divisible by 5");
                else
                    Console.WriteLine("num is not divisible by 5");
            }
            {//code to check num is positive or negative
                Console.WriteLine("Enter the number");
                int number = int.Parse(Console.ReadLine());
                if (number>=0)
                    Console.WriteLine("number is positive");
                else
                    Console.WriteLine("number is negative");
                {//check the num is positive negative or zero
                    Console.WriteLine("enter the num");
                    int no = int.Parse(Console.ReadLine());
                    if (no>0)
                        Console.WriteLine("num is positive");
                    else if (no<0)
                        Console.WriteLine("num is negative");
                    else
                        Console.WriteLine("num is zero");
                }

            }
        }
    }
}
