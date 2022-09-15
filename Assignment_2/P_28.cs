//Write a program in C# Sharp to read any digit, display in the word.
//Test Data :
//4
//Expected Output :
//Four

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_28
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number 0 to 9");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {

                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Saven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Niven");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
