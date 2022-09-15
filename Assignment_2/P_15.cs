//Write a C# Sharp program to read the value of an integer m and display the value of n is 1
//when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
//Test Data : -5
//Expected Output:
//The value of n = -1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_15
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("Enter the number : ");
            m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
                Console.WriteLine("The value of n = 1");
            if (m == 0)
                Console.WriteLine("The Value of n = 0");
            if (m < 0)
                Console.WriteLine("The Value of n = -1");
        }
    }
}
