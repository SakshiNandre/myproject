using System;
using System.Collections.Generic;
using System.Text;
//write a code to calculate percentage of 5 subject marks
namespace myproject
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter eng marks");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maths marks");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sci marks");
            int sci = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marathi marks");
            int marathi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hindi marks");
            int hindi = Convert.ToInt32(Console.ReadLine());
            int sum = eng + maths + sci + marathi + hindi ;
            int percentage = sum / 5;
            Console.WriteLine("Percentage="+percentage);
        }
    }
}
