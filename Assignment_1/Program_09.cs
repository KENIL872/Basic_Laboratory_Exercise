/*Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30 */

using System;

class Program_09
{
    static void Main()
    {
        int A, B, C, D;
        Console.Write("Enter the First number : ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second numbery : ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter thethird number : ");
        C = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the four number : ");
        D = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The average of {0},{1},{2},{3} is {4}",A,B,C,D,((A + B + C + D)/4));
    }
}