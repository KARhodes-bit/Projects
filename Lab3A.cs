/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Kendres Rhodes
Lab#: 3
*/
using System;

namespace Lab3
{
	public class Lab3A
	{
        public static void Main(string[] args)
        {


            int Amount_owed;
            double APR, Monthly_percentage_rate, Minimum_payment;

            Console.Write("Amount owed: $");
            Amount_owed = Convert.ToInt32(Console.ReadLine());
            Console.Write("APR: ");
            APR = float.Parse(Console.ReadLine());
            Monthly_percentage_rate = APR / 12;
            Console.WriteLine("Monthly percentage rate: " + Monthly_percentage_rate);
            Minimum_payment = Amount_owed * APR / 100 / 12;
            Minimum_payment= Math.Round(Minimum_payment, 2);
            Console.WriteLine("Minimum payment: $" + Minimum_payment);
            


        }
    }
}

