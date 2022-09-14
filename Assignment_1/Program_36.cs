//36. Write a C# program to find the largest and lowest values from three integer values.
//Test Data:
//Input first integer:
//15
//Input second integer:
//25
//Input third integer:
//30
//Sample Output
//Largest of three: 30
//Lowest of three: 15

using System;

class Program_36
{
    static void Main()
    {
        int First, Second,Third;
        Console.Write("Input first integer : ");
        First = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second integer : ");
        Second = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Third integer : ");
        Third = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Largest of three: " + Math.Max(First, Math.Max(Second, Third)));
        Console.WriteLine("Lowest of three: " + Math.Min(First, Math.Min(Second, Third)));


    }
}