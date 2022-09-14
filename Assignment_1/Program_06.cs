/*Write a C# Sharp program to print the output of multiplication of three numbers which will be
entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6*/
using System;

class Program_06
{
    static void Main()
    {
        int A, B, C;
        Console.Write("Input the first number to multiply : ");
        A = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Input the second number to multiply : ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the third number to multiply : ");
        C = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multipication Of three number : {0}", (A*B*C));
    }
}