

/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Kendres Rhodes
Lab#: 3
*/

using System;

public class Lab3C
{
    public static void Main(string[] args)
    {
        int num_of_dollars, num_of_cents;
        double quarter, dimes, nickels, pennies, dollars, total;
        Console.Write("Enter the number of quarters: ");
        quarter = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of dimes: ");
        dimes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of nickels: ");
        nickels = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of pennies: ");
        pennies = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You entered " + quarter + " quarters.");
        Console.WriteLine("You entered " + dimes + " dimes.");
        Console.WriteLine("You entered " + nickels + " nickels. ");
        Console.WriteLine("You entered " + pennies + " pennies. ");

        quarter = quarter * 0.25f;
        dimes = dimes * 0.10f;
        nickels = nickels * 0.05f;
        pennies = pennies * 0.01f;
        total = quarter + dimes + nickels + pennies;
        num_of_dollars = (int)total;
        num_of_cents = (int)(total * 100);
        Console.WriteLine("Your total is " + num_of_dollars + " dollars and " + num_of_cents % 100 + " cents.");




    }



}

