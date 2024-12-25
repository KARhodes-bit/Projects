/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 6
*/

using System;

class Lab6C
{
    static void Main(string[] args)
    {
        int userinput, value = 1000, deposit = 0, withdrawal = 0;
        char user2;
        Console.WriteLine("Welcome!");
        Console.WriteLine("You have $1000 in your account. ");

        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0) Make a deposit ");
            Console.WriteLine("1) Make a withdrawal");
            Console.WriteLine("2) Display account value ");
            Console.WriteLine("Please Make a selection: ");
            userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput == 0)
            {
                Console.WriteLine("How much would you like to deposit?: ");
                deposit = Convert.ToInt32(Console.ReadLine());
                value = value + deposit;
                Console.WriteLine("Your current balance is $" + value);
            }
            else if (userinput == 1)
            {
                Console.WriteLine("How much would you like to withdraw?: ");
                withdrawal = Convert.ToInt32(Console.ReadLine());
                value = value - withdrawal;
                Console.WriteLine("Your current balance is $" + value);
            }
            else if (userinput == 2)
            {

                Console.WriteLine("Your current balance is $" + value);

            }
            else
            {
                Console.WriteLine("Invalid entry, please try again.");

            }
            Console.WriteLine("Would you like to return to the main menu (Y/N)?: ");
            user2 = Convert.ToChar(Console.ReadLine());
            user2 = Char.ToUpper(user2);

        } while (user2 == 'Y');
        Console.WriteLine("Thank you for banking with us!");
    }
}
