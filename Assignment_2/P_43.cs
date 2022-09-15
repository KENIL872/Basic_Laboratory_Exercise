//Write a program in C# Sharp to sort elements of the array in descending order.
//Test Data :
//Input the size of array : 3
//Input 3 elements in the array :
//element - 0 : 5
//element - 1 : 9
//element - 2 : 1
//Expected Output :
//Elements of the array in sorted descending order:
//9 5 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_43
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;

            Console.Write("Input the size of array : ");
		    n = Convert.ToInt32(Console.ReadLine());  

            Console.Write("Input {0} elements in the array :\n",n);
            for(i=0;i<n;i++)
            {
	            Console.Write("element - {0} : ",i);
		        arr1[i] = Convert.ToInt32(Console.ReadLine());  
	        }
            for(i=0; i<n; i++)
            {
                for(j=i+1; j<n; j++)
                {
                    if(arr1[i] < arr1[j])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.Write("\nElements of the array in sorted descending order:\n");
            for(i=0; i<n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
	        Console.Write("\n\n");		
        }
    }
}
