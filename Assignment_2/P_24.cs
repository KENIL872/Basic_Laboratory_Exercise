//Write a C# Sharp program to calculate profit and loss on a transaction.
//Test Data :
//500 700
//Expected Output :
//You can book your profit amount : 200
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_24
    {
        static void Main(string[] args)
        {
            int Costprice,selledprice;
            Console.Write("Input the Costprice : ");
            Costprice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the sellerprice : ");
            selledprice = Convert.ToInt32(Console.ReadLine());
            if (Costprice > selledprice)
                Console.WriteLine("You can book your Loss amount : {0}", (Costprice - selledprice));
            else if (Costprice < selledprice)
                Console.WriteLine("You can book your Profit amount : {0}", (selledprice - Costprice));
            else
                Console.WriteLine("You can not book your Loss and Profit");
        }
    }
}
