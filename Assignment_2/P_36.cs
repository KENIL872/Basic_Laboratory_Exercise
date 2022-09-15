//Write a program in C# Sharp to count a total number of duplicate elements in an array.
//Test Data :
//Input the number of elements to be stored in the array :3
//Input 3 elements in the array :
//element - 0 : 5
//element - 1 : 1
//element - 2 : 1
//Expected Output :
//Total number of duplicate elements found in the array is : 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_36
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element - {0} : ", (i));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            Console.ReadLine();
        }
    }
}
