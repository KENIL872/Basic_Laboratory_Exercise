//Write a program in C# Sharp to find the second largest element in an array.
//Test Data :
//Input the size of array : 5
//Input 5 elements in the array :
//element - 0 : 2
//element - 1 : 9
//element - 2 : 1
//element - 3 : 4
//element - 4 : 6
//Expected Output :
//The Second largest element in the array is: 6 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_47
    {
        static void Main(string[] args)
        {
            int n, i, j = 0, lrg, lrg2nd;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            lrg = 0;

            for (i = 0; i < n; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }

            lrg2nd = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (lrg2nd < arr1[i])
                    {
                        lrg2nd = arr1[i];
                    }
                }
            }
            Console.Write("The Second largest element in the array is :  {0} \n\n", lrg2nd);
        }
    }
}
