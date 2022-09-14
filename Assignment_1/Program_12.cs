//Write a C# program to that takes a number as input and display it four times in a row
//(separated by blank spaces), and then four times in the next row, with no separation. You should
//do it two times: Use Console. Write and then use {0}.
//Test Data:
//Enter a digit: 52
//Expected Output:
//25 25 25 25
//25252525
//25 25 25 25
//25252525
using System;

class Program_12
{
    static void Main()
    {
        int X;
        Console.Write("Enter the Number : ");
        X = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <=2; i++)
        {
            Console.WriteLine("{0} {0} {0} {0}", X);
            Console.WriteLine("{0}{0}{0}{0}", X);
        }
    }
}