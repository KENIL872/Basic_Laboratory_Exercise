//write a c# sharp program that takes a number and a width also a number, as input and then
//displays a triangle of that width, using that number.
//test data
//enter a number: 6
//enter the desired width: 6
//expected output :
//666666
//66666
//6666
//666
//66
//6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_02
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = number; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("{0}", number);
                }
                Console.WriteLine();
            }
        }
    }
}

