//Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter
//and area of the circle.
//Test Data
//Input the radius of the circle :
//12
//Expected Output :
//Perimeter of Circle : 75.36

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_04
    {
        static void Main(string[] args)
        {
            int Radius;
            Console.Write("Enter the Radius : ");
            Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perimeter of Circle : {0}",(2*(Math.PI)*Radius));
        }
    }
}
