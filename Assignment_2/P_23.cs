//Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
//Test Data :
//k
//Expected Output :
//The alphabet is a consonant.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_23
    {
        static void Main(string[] args)
        { 
            char symbol;

            Console.Write("Input a aplhabet: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u') || (symbol == 'A') ||
                    (symbol == 'E') || (symbol == 'I') ||
                    (symbol == 'O') || (symbol == 'U'))
                Console.WriteLine("The alphabet is a Vowel");
            else
                Console.WriteLine("The alphabet is a Consonant");
        }
    }
}
