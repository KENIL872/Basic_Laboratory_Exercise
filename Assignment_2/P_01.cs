//write a c# sharp program that takes three letters as input and display them in reverse order.
//test data
//enter letter: b
//enter letter: a
//enter letter: t
//expected output :
//t a b

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_01
    {
        static void Main(string[] args)
        {
            Char First, Second, Third;
            Console.Write("Input First letter : ");
            First = Convert.ToChar(Console.ReadLine());
            Console.Write("Input Second letter : ");
            Second = Convert.ToChar(Console.ReadLine());
            Console.Write("Input Third letter : ");
            Third = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}  {1}  {2}",Third,Second,First);
    
        }
    }
}
