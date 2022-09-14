/*Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of
(x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7*/

using System;

class Program_10
{
    static void Main()
    {
        int X,Y,Z;
        Console.Write("Enter the First number : ");
        X = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second numbery : ");
        Y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter thethird number : ");
        Z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("(x + Y).Z = {0}",((X + Y) * Z));
        Console.WriteLine("X.Z + Y.Z = {0}",((X*Y) + (Y*Z)));
    }
}