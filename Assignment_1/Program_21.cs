//21. Write a C# program to check if an given integer is within 20 of 100 or 200.
//Sample Output:
//Input an integer:
//25
//False
using System;

class Program_21
{
    static void Main()
    {
        int Number;
        Console.Write("Input an integer : ");
        Number = Convert.ToInt32(Console.ReadLine());
        if(Math.Abs(Number - 100) <=20 || Math.Abs(Number - 200) <=20)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}
