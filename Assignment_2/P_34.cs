//Write a program in C# Sharp to find the sum of all elements of the array.
//Test Data :
//Input the number of elements to be stored in the array :3
//Input 3 elements in the array :
//element - 0 : 2
//element - 1 : 5
//element - 2 : 8 
//Expected Output :
//Sum of all elements stored in the array is : 15 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_34
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element - {0} : ", (i));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.Write("\nSum of all elements stored in the array is : {0}\n",sum);
        }
    }
}
