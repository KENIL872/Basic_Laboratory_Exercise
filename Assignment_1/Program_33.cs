//33. Write a C# program to check two given numbers where one is less than 100 and other is
//greater than 200.
//Sample Output:
//Input a first number(<100): 75
//Input a second number(>100): 250
//True
using System;

class Program_33
{
    static void Main()
    {
        int First, Second;
        Console.Write("Input first integer : ");
        First = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second integer : ");
        Second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("two given numbers where one is less than 100 and other is greater than 200.");
        if (First < 100 && Second > 200)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
