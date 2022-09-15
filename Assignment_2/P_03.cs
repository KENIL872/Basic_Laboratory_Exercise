//Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/)
//on them and displays the result of that operation.
//Test Data
//Input first number: 20
//Input operation: -
//Input second number: 12
//Expected Output :
//20 - 12 = 8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_03
    {
        static void Main(string[] args)
        {
            int First,Second;
            string Operation;
            Console.Write("Enter the First : ");
            First = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Operation : ");
            Operation = Console.ReadLine();
            Console.Write("Enter the Second : ");
            Second = Convert.ToInt32(Console.ReadLine());
            if (Operation.Equals("+"))
                Console.WriteLine("Two Number Addition is {0}",(First+Second));
            else if(Operation.Equals("-"))
                Console.WriteLine("Two Number Subtraction is {0}", (First - Second));
            else if(Operation.Equals("*"))
                Console.WriteLine("Two Number Multipication is {0}", (First * Second));
            else
                Console.WriteLine("Two  Number Division is {0}", (First / Second));

        }
    }
}
