//29. Write a C# program to multiply corresponding elements of two arrays of integers.
//Sample Output:
//Array1: [1, 3, -5, 4]
//Array2: [1, 4, -5, -2]
//Multiply corresponding elements of two arrays:
//1 12 25 -8
using System;

class Program_29
{
    static void Main()
    {
        int[] First_Array = { 1, 3, -5, 4 };
        int[] Seconde_Array = {1,4,-5,-2};
        for (int i = 0; i<First_Array.Length; i++)
        {
            Console.Write(First_Array[i] * Seconde_Array[i]+" ");
        }
    }
}