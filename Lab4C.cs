/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Kendres Rhodes
Lab#: 4
*/
using System;

namespace Lab4
{
    public class Lab4C
    {
        public static void Main(string[] args)
        {
            float number;

            Console.WriteLine("Welcome!");
            Console.Write("Please input a number: ");
            number = float.Parse(Console.ReadLine());
            Console.WriteLine("What would you like to do to this number: ");
            Console.WriteLine("0) Get the additive inverse of the number");
            Console.WriteLine("1) Get the reciprocal of the number");
            Console.WriteLine("2) Square the number");
            Console.WriteLine("3) Cube the number");
            Console.WriteLine("4) Exit the program");
            int userChoice;
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 0:
                    Console.WriteLine("The additive inverse of " + number + " is " + -number);
                    break;

                case 1:
                    Console.WriteLine("The reciprocal of " + number + " is " + 1 / number);
                    break;
                case 2:
                    Console.WriteLine("The square of " + number + " is " + number * number);
                    break;
                case 3:
                    Console.WriteLine("The cube of " + number + " is " + number * number * number);
                    break;
                case 4:
                    Console.WriteLine("Thank you, goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again!");
                    break;


            }




        }
    }

}



