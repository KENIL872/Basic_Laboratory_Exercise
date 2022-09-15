//Write a C# Sharp program to check whether a given number is positive or negative.
//Test Data : 14 
//Expected Output :
//14 is a positive number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_12
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("{0} is an Positive Number", number);
            else
                Console.WriteLine("{0} is an Negative Number", number);
        }
    }
}
