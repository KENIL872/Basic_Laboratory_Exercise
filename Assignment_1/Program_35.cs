//35. Write a C# program to check if "HP" appears at second position in a string and returns the
//string without "HP".
//Test Data: PHP Tutorial
//Sample Output:
//P Tutorial
using System;

class Program_35
{
    static void Main()
    {
        string Str ;
        Console.Write("Enter the String : ");
        Str  = Console.ReadLine();
        Console.WriteLine((Str.Substring(1, 2).Equals("HP") ? Str.Remove(1, 2) : Str));
    }
}
