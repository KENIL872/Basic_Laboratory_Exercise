//37. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two
//numbers are same.
//Test Data:
//Input first integer:
//15
//Input second integer:
//12
//Sample Output
//15

using System;

class Program_37
{
    static void Main()
    {
        Console.WriteLine("Input first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        int n = 20;
        var val1 = Math.Abs(x - n);
        var val2 = Math.Abs(y - n);
        Console.WriteLine("the nearest value of 20 of two given integers : {0}", val1 == val2 ? 0 : (val1 < val2 ? x : y));

    }
}