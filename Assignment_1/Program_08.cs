/*Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
Enter the number: 5*/
using System;

class Program_08
{
    static void Main()
    {
        int table;
        Console.Write("Input the first number to multiply : ");
        table = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}",i,table,(table * i));
        }
   }
}
