//Write a program in C# Sharp to delete an element at desired position from an array.
//Test Data :
//Input the size of array : 5
//Input 5 elements in the array in ascending order:
//element - 0 : 1
//element - 1 : 2
//element - 2 : 3
//element - 3 : 4
//element - 4 : 5
//Input the position where to delete: 3
//Expected Output :
//The new list is : 1 2 4 5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_46
    {
        static void Main(string[] args)
        {
            int i, pos, n;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete: ");
            pos = Convert.ToInt32(Console.ReadLine());

            i = 0;
            while (i != pos - 1)
                i++;

            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }
}
