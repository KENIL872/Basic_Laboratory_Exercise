//Write a C# Sharp program that takes the radius of a sphere as input and calculate and display
//the surface and volume of the sphere.
//Test Data:
//Radius: 2
//Expected Output:
//50.26548
//33.51032
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_06
    {
        static void Main(string[] args)
        {
            int Radius;
            Console.Write("Enter the Radius : ");
            Radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sphere Surface: {0}", (4 * (Math.PI) * (Radius * Radius)));
            Console.WriteLine("sphere Volume: {0}", ((4* (Math.PI) * (Radius*Radius*Radius)))/3);
        }
    }
}
