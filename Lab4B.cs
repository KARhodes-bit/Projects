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
    public class Lab4B
    {
        public static void Main(string[] args)
        {
            // always use .Equals() for strings

            string Day;

            Console.Write("Enter the day: ");
            Day = Console.ReadLine();
            Day = Day.ToLower();

            if (Day.Equals("monday"))
            {
                Console.WriteLine("I have class today!");
            }
            else if (Day.Equals("wednesday"))
            {
                Console.WriteLine("I have class today!");
            }
            else if (Day.Equals("friday"))
            {
                Console.WriteLine("It's Friday! Friday! Gotta get down on Friday!");
            }
            else
            {
                Console.WriteLine("I should use this time to do my homework.");
            }

        }
    }

}