using System;
using System.Collections.Generic;
using System.Text;
//Write code to calculate area of triangle
namespace myproject
{
    class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("base of triangle is:");
            int BASE = int.Parse(Console.ReadLine());
            Console.WriteLine("height is:");
            int height = int.Parse(Console.ReadLine());
            int area = height * BASE * 1 / 2;
            Console.WriteLine("area is " + area);
        }
    }
}
