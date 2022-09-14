//20. Write a C# program to check the sum of the two given integers and return true if one of the
//integer is 20 or if their sum is 20.
using System;

class Program_20
{
    static void Main()
    {
        int First, Second, Sum = 0;
        Console.Write("Input first integer : ");
        First = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second integer : ");
        Second = Convert.ToInt32(Console.ReadLine());
        Sum = First + Second;
        Console.WriteLine("the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.");
        if (Sum.Equals(First) || Sum.Equals(Second))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}