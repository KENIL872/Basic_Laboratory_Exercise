//Write a program in C# Sharp to calculate and print the Electricity bill of a given customer.
//The customer id., name and unit consumed by the user should be taken from the keyboard and
//display the total amount to pay to the customer. The charge are as follow :

//Unit                              Charge/unit
//upto 199                           @1.20
//200 and above but less than 400    @1.50
//400 and above but less than 600    @1.80
//600 and above                      @2.00

//If bill exceeds Rs. 400 then a surcharge of 15% will be charged and the minimum bill should be
//of Rs. 100/-
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_25
    {
        static void Main(string[] args)
        {
            int Customber_id;
            string Name;
            double bill, unit;
            Console.Write("Enter the Customber Id : ");
            Customber_id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter the Unit : ");
            unit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            if (unit <= 199)
            {
                bill = unit * 1.20;
                if (bill < 100)
                    Console.WriteLine("you have pay 100/-");
                else
                {
                    if (bill < 400)
                    {
                        Console.WriteLine("you have pay {0}", bill);
                    }
                    else
                    {
                        Double charge = bill * 15 / 100;
                        Console.WriteLine("your bill amount is {0}", bill);
                        Console.WriteLine("your bill charge is {0}", charge);
                        Console.WriteLine("Your Payable Bill Amount is {0}", (bill + charge));
                    }
                }
            }
            else if (unit >= 200 && unit < 400)
            {
                unit = unit - 199;
                bill = (unit*1.50) + 238.8;
                if (bill < 100)
                    Console.WriteLine("you have pay 100/-");
                else
                {
                    if (bill < 400)
                    {
                        Console.WriteLine("you have pay {0}", bill);
                    }
                    else
                    {
                        double charge = bill * 15 / 100;
                        Console.WriteLine("your bill amount is {0}", bill);
                        Console.WriteLine("your bill charge is {0}", charge);
                        Console.WriteLine("your payable bill amount is {0}", (bill + charge));
                    }
                }
            }
            else if (unit >= 400 && unit < 600)
            {
                unit = unit - 399;
                bill = (unit * 1.80f) + 238.8 + 298.5;
                if (bill < 100)
                    Console.WriteLine("you have pay 100/-");
                else
                {
                    if (bill < 400)
                    {
                        Console.WriteLine("you have pay {0}", bill);
                    }
                    else
                    {
                        Double charge = bill * 15 / 100;
                        Console.WriteLine("your bill amount is {0}", bill);
                        Console.WriteLine("your bill charge is {0}", charge);
                        Console.WriteLine("Your Payable Bill Amount is {0}", (bill + charge));
                    }
                }
            }
            else
            {
                unit = unit - 599;
                bill = (unit* 2.00) + 238.8 + 298.5 + 358.2;
                if (bill < 100)
                    Console.WriteLine("you have pay 100/-");
                else
                {
                    if (bill < 400)
                    {
                        Console.WriteLine("you have pay {0}", bill);
                    }
                    else
                    {
                        Double charge = bill * 15 / 100;
                        Console.WriteLine("your bill amount is {0}", bill);
                        Console.WriteLine("your bill charge is {0}", charge);
                        Console.WriteLine("Your Payable Bill Amount is {0}", (bill + charge));
                    }
                }
            }
        }
    }
}
