/*Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5*/
using System;

class Program_05
{
    static void Main()
    {
        int A, B, C;
        Console.Write("Enter First Integer: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter First Integer: ");
        B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("After Swpping");
        C = A;
        A = B;
        B = C;
        Console.WriteLine("First Integer : {0}", A);
        Console.WriteLine("First Integer : {0}", B);
    }
}