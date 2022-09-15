//Write a C# Sharp program to find the eligibility of admission for a professional course based
//on the following criteria:
//Marks in Maths >=65
//Marks in Phy >=55
//Marks in Chem>=50
//Total in all three subject >=180
//or
//Total in Math and Subjects >=140
//Test Data :
//Input the marks obtained in Physics :65
//Input the marks obtained in Chemistry :51
//Input the marks obtained in Mathematics :72
//Expected Output :
//The candidate is eligible for admission.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_18
    {
        static void Main(string[] args)
        {
            int math, phy, chem;
            Console.Write("Input the marks obtained in Mathematics : ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry: ");
            chem = Convert.ToInt32(Console.ReadLine());
            int total = math + phy + chem;
            if (math >= 65 && phy >= 55 && chem >= 50 && total >= 180)
                Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}
