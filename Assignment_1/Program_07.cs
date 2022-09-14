/*Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and
dividing of two numbers which will be entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4*/
using System;

class Program_07
{
    static void Main()
    {
        int A, B;
        Console.Write("Input the first number to multiply : ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the second number to multiply : ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition of tow number : {0}", (A + B));
        Console.WriteLine("Subtrection of tow number : {0}", (A - B));
        Console.WriteLine("Multiplication of tow number : {0}", (A * B));
        Console.WriteLine("Divition of tow number : {0}", (A / B));
        Console.WriteLine("Modulo of tow number : {0}", (A % B));
    }
}