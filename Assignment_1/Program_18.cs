//18. Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.

using System;

class Program_18
{
    static void Main()
    {
        int First, Second,Sum =0;
        Console.Write("Input first integer : ");
        First = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second integer : ");
        Second = Convert.ToInt32(Console.ReadLine());
        if (First == Second)
            Sum = (First + Second) * 3;
        else
            Sum = First + Second;
        Console.WriteLine("Sum of tow number : {0}", Sum);
    }
}