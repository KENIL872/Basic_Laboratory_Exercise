//Write a C# Sharp program that takes an age (for example 20) as input and prints something
//as "You look older than 20".
//Test Data:
//Enter your age – 25
//Expected Output:
//You look older than 25
using System;

class Program_11
{
    static void Main()
    {
        int X;
        Console.Write("Enter the Age : ");
        X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You look older than {0} ", X);
    }
}