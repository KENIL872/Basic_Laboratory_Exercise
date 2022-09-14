//23. Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
//Sample Output:
//Odd numbers from 1 to 99. Prints one number per line.
//1
//3
//5
//7
//9
//...
//95
//97
//99
using System;

class Program_23
{
    static void Main()
    {
        for (int i = 0; i <=99; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}