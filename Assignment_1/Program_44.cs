//44. Write a C# program to create a new array of length containing the middle elements of three
//arrays (each length 3) of integers.
//Test Data:
//Array1: [1, 2, 5]
//Array2: [0, 3, 8]
//Array3: [-1, 0, 2]
//New array: [2, 3, 0] 
using System;

class Program_44
{
    static void Main()
    {

        int[] array1 = { 1, 2, 5 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
        int[] array2 = { 0, 3, 8 };
        Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
        int[] array3 = { -1, 0, 2 };
        Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
        int[] new_array = { array1[1], array2[1], array3[1] };
        Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));

    }
}