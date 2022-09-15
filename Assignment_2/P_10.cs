//Write a C# Sharp program to accept two integers and check whether they are equal or not.
//Test Data :
//Input 1st number: 5
//Input 2nd number: 5
//Expected Output :
//5 and 5 are equal 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_10
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Enter the number1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 == number2)
                Console.WriteLine("{0} and {1} are Equal", number1, number2);
            else
                Console.WriteLine("{0} and {1} are not Equal", number1, number2);
        }
    }
}
