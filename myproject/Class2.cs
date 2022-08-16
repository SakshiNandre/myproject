using System; 
using System.Collections.Generic;
using System.Text;
//write a program whether the no is divisible by 5 & 11 or not
namespace myproject
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if((number%5==0)||(number%11==0))
                {
                Console.WriteLine("number is divisible");
            }
            else
            {
                Console.WriteLine("number is not divisible");
            }
        }
    }
}
