//Write a C# Sharp program to check whether a given number is even or odd.
//Test Data : 15
//Expected Output :
//15 is an odd integer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_11
    {
        static void Main(string[] main)
        {
            int number;
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("{0} is an Even Number", number);
            else
                Console.WriteLine("{0} is an Odd Number",number);
        }
    }
}
