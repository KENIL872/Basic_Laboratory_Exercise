//15. Write a C# program remove specified a character from a non-empty string using index of a
//character.
//Test Data:
//Atmiya University
//Sample Output:
//Atiya University
//Atmiya niversity

using System;

class Program_15
{
    static void Main()
    {
        string S = "Atmiya University";
        Console.WriteLine("{0}");
        Console.WriteLine("{0}",S.Remove(2,1));
        Console.WriteLine("{0}",S.Remove(7,1));
    }
}