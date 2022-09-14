//30. Write a C# program to create a new string of four copies, taking last four characters from a
//given string. If the length of the given string is less than 4 return the original one.
//Sample Output:
//Input a string : The quick brown fox jumps over the lazy dog.
//dog.dog.dog.dog.

using System;

class Program_30
{
    static void Main()
    {
        string Str;
        Console.Write("Enter the String : ");
        Str = Console.ReadLine();
        if (Str.Length < 4)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Str);
            }
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write(Str.Substring(Str.Length-4));
            }
        }
    }
}