//32. Write a C# program to check if a string starts with a specified word.
//Note: Suppose the sentence starts with "Hello"
//Sample Data: string1 = "Hello how are you?"
//Result: Hello.
//Sample Output:
//Input a string : Hello how are you?
//True
using System;

class Program_32
{
    static void Main()
    {
        String Str;
        Console.Write("Enter the string : ");
        Str = Console.ReadLine();
        if (Str.StartsWith("Hello"))
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}