//17. Write a C# program to check two given integers and return true if one is negative and one is positive.
//Sample Output:
//Input first integer: -5
//Input second integer: 25
//Check if one is negative and one is positive: True
using System;

class Program_17
{
    static void Main()
    { 
        int First, Second;
        Console.Write("Input first integer : ");
        First = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second integer : ");
        Second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("if one is negative and one is positive: return true other wise false");
        if ((First < 0 && Second > 0) || (First > 0 && Second < 0))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}