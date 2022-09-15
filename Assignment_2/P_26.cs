//Write a program in C# Sharp to accept a grade and declare the equivalent description :
//  Grade   Description
//  E       Excellent
//  V       Very Good
//  G       Good
//  A       Average
//  F       Fail
//Test Data :
//Input the grade :a
//Expected Output :
//You have chosen : Average

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_26
    {
        static void Main(string[] args)
        {
            char grade;
            Console.Write("Enter the Grade : ");
            grade = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (grade)
            {
                case 'E':
                         Console.WriteLine("You have chosen : Excellent");
                         break;
                case 'V':
                         Console.WriteLine("You have chosen : Very Good");
                         break;
                case 'G':
                         Console.WriteLine("You have chosen : Good ");
                         break;
                case 'A':
                         Console.WriteLine("You have chosen : Average");
                         break;
                case 'F':
                         Console.WriteLine("You have chosen : Fails");
                         break;
                default:
                        Console.WriteLine("Invalid Grade Found.");
                        break;
            }
        }
    }
}
