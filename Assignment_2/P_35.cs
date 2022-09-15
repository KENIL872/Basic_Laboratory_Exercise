//Write a program in C# Sharp to copy the elements one array into another array.
//Test Data :
//Input the number of elements to be stored in the array :3
//Input 3 elements in the array :
//element - 0 : 15
//element - 1 : 10
//element - 2 : 12
//Expected Output:
//The elements stored in the first array are :
//15 10 12
//The elements copied into the second array are :
//15 10 12 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_35
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element - {0} : ", (i));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe elements stored in the first array are : \n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
                arr2[i] = arr[i];
            }
            Console.Write("\n");

            Console.Write("\nThe elements copied into the second array are : \n");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.Write("\n");
        }
    }
}
