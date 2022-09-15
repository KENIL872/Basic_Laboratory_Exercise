//Write a C# Sharp program to find whether a given year is a leap year or not.
//Test Data : 2016
//Expected Output :
//2016 is a leap year.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_13
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if(((number %400 == 0) && (number % 100 != 0)) || (number % 4 == 0))
                Console.WriteLine("{0} is a Leap Year",number);
            else
                Console.WriteLine("{0} is not a Leap Year", number);
        }
    }
}
