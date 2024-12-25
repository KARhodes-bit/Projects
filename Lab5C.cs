/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 5
*/

using System;

class Lab5C
{
    static void Main(string[] args)
    {
        int userchoicex, userchoicey;
        Console.Write("Enter x: ");
        userchoicex = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter y: ");
        userchoicey = Convert.ToInt32(Console.ReadLine());

        if (userchoicex == 0 && userchoicey == 0)
        {
            Console.WriteLine("This point is on the origin. ");

        }
        else if (userchoicex == 0)
        {
            Console.WriteLine("This point is on the y axis. ");
        }
        else if (userchoicey == 0)
        {
            Console.WriteLine("This point is on the x axis. ");
        }
        else if (userchoicex > 0 && userchoicey > 0)
        {
            Console.WriteLine(" This point is in the first quadrant. ");
        }
        else if (userchoicex < 0 && userchoicey > 0)
        {
            Console.WriteLine("This point is in the second quadrant.");
        }
        else if (userchoicex < 0 && userchoicey < 0)
        {
            Console.WriteLine("This point is in the third quadrant.");
        }
        else
        {
            Console.WriteLine("This point is in the fourth quadrant.");
        }



    }
    
}





