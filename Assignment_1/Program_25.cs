//25. Write a C# program and compute the sum of the digits of an integer.
//Sample Output:
//Input a number(integer): 12
//Sum of the digits of the said integer: 3
using System;

class Program_25
{
    static void Main()
    {
        Console.Write("Input  a number(integer): ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine("Sum of the digits of the said integer: " + sum);

    }
}