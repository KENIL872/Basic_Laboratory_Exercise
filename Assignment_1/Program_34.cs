//34. Write a C# program to check if an integer (from the two given integers) is in the range -10 to
//10.
//Sample Output:
//Input a first number: -5
//Input a second number: 8
//True

using System;

class Program_34
{
    static void Main()
    {
        int First, Second;
        Console.Write("Input first integer : ");
        First = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second integer : ");
        Second = Convert.ToInt32(Console.ReadLine());
        if ((First >= -10 && First <= 10) && (Second >= -10 && Second <=10 ))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}