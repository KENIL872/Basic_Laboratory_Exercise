//14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
//Test Data:
//Enter the amount of celsius: 30
//Expected Output:
//Kelvin = 303
//Fahrenheit = 86
using System;

class Program_14
{
    static void Main()
    {
        double Kelvin, Fahernheit, Celsius;
        Console.Write("Enter the amount of celsius : ");
        Celsius = Convert.ToDouble(Console.ReadLine());
        Kelvin = Celsius + 273.15;
        Fahernheit = (Celsius*1.8)+ 32;
        Console.WriteLine("Kelvin : {0}",Kelvin);
        Console.WriteLine("Fahernheit : {0}",Fahernheit);
    }
}