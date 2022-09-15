//Write a C# Sharp program that takes distance and time as input and displays the speed in
//kilometers per hour and miles per hour.
//Test Data:
//Input distance(meters): 50000
//Input timeSec(hour): 1
//Input timeSec(minutes): 35
//Input timeSec(seconds): 56
//Expected Output:
//Your speed in meters/sec is 8.686588
//Your speed in km/h is 31.27172
//Your speed in miles/h is 19.4355

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_05
    {
        static void Main(string[] args)
        {
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("\nYour speed in metres/sec is {0}", mps);
            Console.WriteLine("\nYour speed in km/h is {0}", kph);
            Console.WriteLine("\nYour speed in miles/h is {0}", mph);
        }
    }
}
