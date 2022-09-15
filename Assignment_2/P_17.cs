//Write a C# Sharp program to find the largest of three numbers.
//Test Data :
//Input the 1st number :25
//Input the 2nd number :63
//Input the 3rd number :10
//Expected Output :
//The 2nd Number is the greatest among three 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_17
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.Write("Input the 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2st number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3st number : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                    Console.WriteLine("The 1nd Number is the greatest among three");
                else
                    Console.WriteLine("The 3nd Number is the greatest among three");
            }
            else
            {
                if (num2 > num3)
                    Console.WriteLine("The 2nd Number is the greatest among three");
                else
                    Console.WriteLine("The 3nd Number is the greatest among three");
            }
        }
    }
}
