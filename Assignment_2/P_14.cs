//Write a C# Sharp program to read the age of a candidate and determine whether it is eligible
//for casting his/her own vote.
//Test Data : 21
//Expected Output:
//Congratulation! You are eligible for casting your vote.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_14
    {
        static void Main(string[] args)
        {
            int Age;
            Console.Write("Enter Your Age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote", Age);
            else
                Console.WriteLine("Sorry! You are not eligible for casting your voter", Age);
        }
    }
}
