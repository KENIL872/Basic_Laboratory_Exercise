//Write a C# Sharp program to check whether a triangle can be formed by the given value for
//the angles.
//Test Data :
//40 55 65
//Expected Output :
//The triangle is not valid

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_22
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
            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
                Console.WriteLine("The triangle is not valid");
            else
                Console.WriteLine("The triangle is valid");
        }
    }
}
