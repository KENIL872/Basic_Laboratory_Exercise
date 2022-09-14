//45. Write a C# program to check if an array contains an odd number.
//Test Data:
//Original array: [2, 4, 7, 8, 6]
//Check if an array contains an odd number? True 

using System;

class Program_45
{
    static void Main()
    {
        int[] Array = { 2, 4, 7, 8, 6 };
        foreach (var n in Array)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}