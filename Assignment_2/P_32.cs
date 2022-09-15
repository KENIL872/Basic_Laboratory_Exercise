//Write a program in C# Sharp to store elements in an array and print it.
//Test Data:
//Input 10 elements in the array:
//element - 0 : 1
//element - 1 : 1
//element - 2 : 2
//...
//Expected Output :
//Elements in array are: 1 1 2 3 4 5 6 7 8 9 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_32
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element - {0} : ", (i));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are : ");
            foreach (var item in arr)
            {
                Console.Write("{0} ",item);
            }
            Console.Write("\n");
        }
    }
}
