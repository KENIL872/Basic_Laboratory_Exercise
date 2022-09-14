//28. Write a C# program to convert a hexadecimal number to decimal number.
//Sample Output:
//Hexadecimal number: 4B0
//Convert toDecimal number: 1200
using System;

class Program_28
{
    static void Main()
    {
        string hexval;
        Console.Write("Enter the Hexadecimal code : ");
        hexval = Console.ReadLine();
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " + decValue);
    }
}