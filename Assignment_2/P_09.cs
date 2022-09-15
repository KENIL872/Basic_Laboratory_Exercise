//Write a C# Sharp program that takes a decimal number as input and displays its equivalent in
//binary form.
//Test Data:
//Number to convert (or "end")? 25
//Expected Output:
//Binary: 11001
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_09
    {
        static void Main(string[] args)
        {
            int number;
            string result="";
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 1)
            {
                int remainder = number % 2;
                result = Convert.ToString(remainder) + result;
                number /= 2;
            }
            result = Convert.ToString(number) + result;
            Console.WriteLine("Binary : {0}", result);
        }
    }
}
