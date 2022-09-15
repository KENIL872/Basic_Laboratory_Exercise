//Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.
//Test Data :
//Input elements in the matrix :
//element - [0],[0] : 1
//element - [0],[1] : 2
//element - [0],[2] : 3
//element - [1],[0] : 4
//element - [1],[1] : 5
//element - [1],[2] : 6
//element - [2],[0] : 7
//element - [2],[1] : 8
//element - [2],[2] : 9
//Expected Output :
//The matrix is :
//1 2 3
//4 5 6
//7 8 9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_49
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[3, 3];

            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
        }
    }
}
