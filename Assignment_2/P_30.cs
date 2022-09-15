//Write a program in C# Sharp to read any Month Number in integer and display the number
//of days for this month.
//Test Data :
//7
//Expected Output:
//Month have 31 days

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_30
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number 1 to 12");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {

                case 1:
                    Console.WriteLine("31 days");
                    break;
                case 2:
                    Console.WriteLine("28 days (regular year),29 days (leap year)");
                    break;
                case 3:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                    Console.WriteLine("30 days");
                    break;
                case 5:
                    Console.WriteLine("31 days");
                    break;
                case 6:
                    Console.WriteLine("30 days");
                    break;
                case 7:
                    Console.WriteLine("31 days");
                    break;
                case 8:
                    Console.WriteLine("31 days");
                    break;
                case 9:
                    Console.WriteLine("30 days");
                    break;
                case 10:
                    Console.WriteLine("31 days");
                    break;
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 12:
                    Console.WriteLine("31 days");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
