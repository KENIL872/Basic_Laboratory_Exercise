//Write a program in C# Sharp to insert New value in the array (unsorted list ).
//Test Data :
//Input the size of array : 4
//Input 4 elements in the array in ascending order:
//element - 0 : 1
//element - 1 : 8
//element - 2 : 7
//element - 3 : 10
//Core 12: Programming with C#.NET | Atmiya University 11 | P a g e
//Input the value to be inserted : 5
//Input the Position, where the value to be inserted :2
//Expected Output :
//The current list of the array :
//1 8 7 10
//After Insert the element the new list is :
//1 5 8 7 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_45
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i, n, p, x;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Stored values into the array*/
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the value to be inserted : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array :\n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);

            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];

            arr1[p - 1] = x;


            Console.Write("\n\nAfter Insert the element the new list is :\n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n\n");
        }
    }
}
