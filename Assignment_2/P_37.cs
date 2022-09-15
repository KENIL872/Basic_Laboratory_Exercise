//Write a program in C# Sharp to print all unique elements in an array.
//Test Data :
//Input the number of elements to be stored in the array :3
//Input 3 elements in the array :
//element - 0 : 1
//element - 1 : 5
//element - 2 : 1
//Expected Output :
//The unique elements found in the array are :
//5 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_37
    {
        static void Main(string[] args)
        {
            int n, ctr = 0;
            int[] arr1 = new int[100];
            int i, j, k;

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;

                for (j = 0; j < i - 1; j++)
                {

                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }

                for (k = i + 1; k < n; k++)
                {

                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }

                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }

                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");
        }
    }
}
