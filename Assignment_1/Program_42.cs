//42. Write a C# program to rotate an array (length 3) of integers in left direction.
//Test Data:
//Array1: [1, 2, 8]
//After rotating array becomes: [2, 8, 1]
using System;

class Program_42
{
    static void Main()
    {
        int[] nums = { 1, 2, 8 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var temp = nums[0];
        for (var i = 0; i < nums.Length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[nums.Length - 1] = temp;
        Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));

    }
}