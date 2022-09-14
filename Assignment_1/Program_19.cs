//19. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of 
//the difference if the first number is greater than second number.
using System;

class Program_19
{
    static void Main()
    {
        int First, Second, Absolute= 0;
        Console.Write("Input first integer : ");
        First = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second integer : ");
        Second = Convert.ToInt32(Console.ReadLine());
        if (First > Second)
            Absolute = (First - Second) * 2;
        else
            Absolute = Second - First;
        Console.WriteLine("the absolute value of the difference between two given numbers : {0}", Absolute);
    }
}