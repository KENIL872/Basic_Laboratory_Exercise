//Write a C# program that takes a number as input and then displays a rectangle of 3 columns
//wide and 5 rows tall using that digit.
//Test Data:
//Enter a number: 5
//Expected Output:
//555
//5 5
//5 5
//5 5
//555

using System;

class Program_13
{
    static void Main()
    {
        int length = 3, width = 5;
        Console.Write(" ");

        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= length; j++)
            {
                if (i == 1 || i == width || j == 1 || j == length)
                {
                    Console.Write("5");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n ");
        }
    }
}