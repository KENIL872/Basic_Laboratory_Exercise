//43. Write a C# program to get the larger value between first and last element of an array (length
//3) of integers.
//Test Data:
//Array1: [1, 2, 5, 7, 8]
//Highest value between first and last values of the said array: 8 
using System;

class Program_43
{
    static void Main()
    {
        int[] nums = { 1, 2, 5, 7, 8 };
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var h_val = nums[0];
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[0])
                h_val = nums[i];
        }
        Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);

    }
}