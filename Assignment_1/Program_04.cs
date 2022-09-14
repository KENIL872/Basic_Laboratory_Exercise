//Write a C# Sharp program to print the result of the specified operations.
//Test data:
// -1 + 4 * 6
// ( 35+ 5 ) % 7
// 14 + -4 * 6 / 11
// 2 + 15 / 6 * 1 - 7 % 2
using System;

class Program_04
{
    static void Main()
    {
        Console.WriteLine("operations_1. -1 + 4 * 6 : " + (-1 + 4 * 6));
        Console.WriteLine("operations_2. ( 35+ 5 ) % 7 : " + ((35 + 5) % 7));
        Console.WriteLine("operations_3. 14 + -4 * 6 / 11 : " + (14 + -4 * 6 / 11));
        Console.WriteLine("operations_4. 2 + 15 / 6 * 1 - 7 % 2 : " + (2 + 15 / 6 * 1 - 7 % 2));
    }
}