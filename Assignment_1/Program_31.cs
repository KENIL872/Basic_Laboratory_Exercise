//31. Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7.
//Sample Output:
//Input first integer:
//15
//True

using System;

class Program_31
{
    static void Main()
    {
        Console.Write("Input first integer : ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 3 == 0 || x % 7 == 0)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}