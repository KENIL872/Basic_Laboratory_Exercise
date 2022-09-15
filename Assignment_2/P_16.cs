//Write a C# Sharp program to accept the height of a person in
//centimeter and categorize the person according to their height.
//if less the 150 when person is Dwarf
//if eqale 150 when person is Average height
//if more then 150 when person is Tall
//Test Data : 135
//Expected Output :
//The person is Dwarf.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_16
    {
        static void Main(string[] args)
        {
            int height;
            Console.Write("Enter the height(centimeter): ");
            height = Convert.ToInt32(Console.ReadLine());
            if (height < 150)
                Console.WriteLine("The person is Dwarf.");
            if (height == 150)
                Console.WriteLine("The person is Average Height.");
            if (height > 150)
                Console.WriteLine("The person is Tall.");
        }
    }
}
