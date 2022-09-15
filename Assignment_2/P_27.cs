//Write a program in C# Sharp to read any day number in integer and display day name in the
//word.
//Test Data :
//4
//Expected Output :
//Thursday

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_27
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number 1 to 7");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {

                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}

