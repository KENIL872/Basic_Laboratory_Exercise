//Write a C# Sharp program to read temperature in centigrade and display a suitable message
//according to temperature state below :
//Temp < 0 then Freezing weather
//Temp 0-10 then Very Cold weather
//Temp 10-20 then Cold weather
//Temp 20-30 then Normal in Temp
//Temp 30-40 then Its Hot
//Temp >=40 then Its Very Hot
//Test Data :
//42
//Expected Output :
//Its very hot.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_20
    {
        static void Main(string[] args)
        {
            int temp;
            Console.Write("Enter the temperature in centigrade : ");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
                Console.WriteLine("Freezing weather");
            else if (temp > 0 && temp < 10)
                Console.WriteLine("Very Cold weather");
            else if (temp >= 10 && temp < 20)
                Console.WriteLine("Cold weather");
            else if (temp >= 20 && temp < 30)
                Console.WriteLine("Normal in Temperatuer");
            else if (temp >= 30 && temp < 40)
                Console.WriteLine("Hot");
            else if(temp>=40)
                Console.WriteLine("Very Hot");
        }
    }
}
