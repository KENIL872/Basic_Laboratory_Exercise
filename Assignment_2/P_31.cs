//Write a program in C# Sharp which is a Menu-Driven Program to perform a simple
//calculation.
//Test Date and Expected Output
//Enter the first Integer :10
//Enter the second Integer :2
//Here are the options :
//1-Addition.
//2-Substraction.
//3-Multiplication.
//4-Division.
//5-Exit.
//Input your choice :3
//The Multiplication of 10 and 2 is: 20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_31
    {
        static void Main(string[] args)
        {
            int number1, number2, option;
            Console.Write("Enter the number1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n Enter you Option : ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Addition of {0} and {1} : {2}",number1,number2,(number1+number2));
                    break;
                case 2:
                    Console.WriteLine("Substractionof {0} and {1} : {2}", number1, number2, (number1 - number2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication of {0} and {1} : {2}", number1, number2, (number1 * number2));
                    break;
                case 4:
                    Console.WriteLine("Division of {0} and {1} : {2}", number1, number2, (number1 / number2));
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
