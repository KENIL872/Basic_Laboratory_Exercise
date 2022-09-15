//Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
//Test Data :
//50 50 60
//Expected Output :
//This is an isosceles triangle.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_21
    {
        static void Main(string[] args)
        {
            int side1, side2, side3;
            Console.Write("Input the 1st side : ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2st side : ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3st side : ");
            side3 = Convert.ToInt32(Console.ReadLine());
            if (side1 == side2 && side2 == side3 && side3 == side1)
                Console.WriteLine("This is an Equilateral triangle.");
            else if (side1 == side2 || side2 == side3 || side3 == side1)
                Console.WriteLine("This is an isosceles triangle.");
            else
                Console.WriteLine("This is an Scalene triangle.");


        }
    }
}
