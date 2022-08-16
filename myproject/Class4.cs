using System;
using System.Collections.Generic;
using System.Text;
//Write a program to input any alphabet and check whether it is vowel or consonant
namespace myproject
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a alphabet");
            char alphabet = Convert.ToChar(Console.ReadLine());
            switch(alphabet)
                {
                case 'a':
                    Console.WriteLine("it is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("it is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("it is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("it is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("it is a vowel");
                    break;
                case 'v':
                    Console.WriteLine("it is a vowel");
                    break;
                case 'w':
                    Console.WriteLine("it is a vowel");
                    break;
                default:
                    Console.WriteLine("it is a consonant");
                    break;

            }

        }
    }
}
