//Write a program in C# Sharp to read n number of values in an array and display it in reverse
//order.
//Test Data :
//Input the number of elements to store in the array :3
//Input 3 number of elements in the array :
//element - 0 : 2
//element - 1 : 5
//element - 2 : 7
//Expected Output:
//The values store into the array are:
//2 5 7
//The values store into the array in reverse are :
//7 5 2 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_33
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element - {0} : ", (i));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are :\n");
            for (int i = 0; i < arr.Length;i++ )
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n");

            Console.Write("\nThe values store into the array in reverse are : \n");
            for (int i = arr.Length-1; i >=0;i-- )
            {
                Console.Write("{0} ",arr[i] );
            }
            Console.Write("\n");
        }
    }
}
