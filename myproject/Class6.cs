using System;
using System.Collections.Generic;
using System.Text;
//Write a program to input any character and check whether it is alphabet, digit or special character
namespace myproject
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character");
                char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "is a Special character.. ");
            }

        }
    }
}
