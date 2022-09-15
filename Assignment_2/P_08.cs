//Write a C# Sharp program that takes two numbers as input and returns true or false when both
//numbers are even or odd.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_08
    {
        static void Main(string[] agrs)
        {
            int number1,number2;
            Console.Write("Enter the number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (((number1 % 2 == 0) && (number2 % 2 == 0))||((number1 % 2 == 1) && (number2 % 2 == 1)))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
