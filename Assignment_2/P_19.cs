//Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the
//total, percentage and division.
//Test Data :
//Input the Roll Number of the student :784
//Input the Name of the Student :James
//Input the marks of Physics, Chemistry and Computer Application : 70 80 90
//Expected Output :
//Roll No : 784
//Name of Student : James
//Marks in Physics : 70
//Marks in Chemistry : 80
//Marks in Computer Application : 90
//Total Marks = 240
//Percentage = 80.00
//Division = First
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_19
    {
        static void Main(string[] args)
        {
            int phy, chem,CA,Roll_no,Total;
            Double per;
            string Name;
            Console.Write("Enter the Roll no : ");
            Roll_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application : ");
            phy = Convert.ToInt32(Console.ReadLine());
            chem = Convert.ToInt32(Console.ReadLine());
            CA = Convert.ToInt32(Console.ReadLine());
            Total = phy + chem + CA;
            per = Total / 3;

            Console.WriteLine("Roll No : {0}", Roll_no);
            Console.WriteLine("Name of Student :{0}", Name);
            Console.WriteLine("Marks in Physics :{0}", phy);
            Console.WriteLine("Marks in Chemistry :{0}", chem);
            Console.WriteLine("Marks in Computer Application :{0}", CA);
            Console.WriteLine("Total Marks :{0}", Total);
            Console.WriteLine("Marks in Percentage :{0}", per);
            if (per >= 80)
                Console.WriteLine("Division = Frist");
            else if (per >= 60)
                Console.WriteLine("Division = Second");
            else if (per >= 50)
                Console.WriteLine("Division = Third");
            else
                Console.WriteLine("Division = Pass");

        }
    }
}
