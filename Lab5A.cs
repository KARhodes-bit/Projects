/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 5
*/


using System;

class Lab5A
{
    static void Main(string[] args)
    {
        string userchoice, userchoice2;
        Console.Write("Do yoy have a driving permit (Y/N)? ");
        userchoice = Console.ReadLine();
        userchoice = userchoice.ToUpper();
        
        if (userchoice.Equals("N"))
        {
            Console.WriteLine("Driving permit is a prerequisite to purchase a vehicle! ");
        }
        else if (userchoice.Equals("Y"))
        {
            Console.Write("Do you have a commercial driving license (Y/N)? ");
            userchoice2 = Console.ReadLine();
            userchoice2 = userchoice2.ToUpper();
            if (userchoice2.Equals("Y"))
            {
                Console.WriteLine("Congratulations! You can purchase a vehicle, let's start talking options!");

            }
            else if (userchoice2.Equals("N"))
            {
                Console.WriteLine("Commercial driving license is a prerequisite to purchase a vehicle! ");
            }
        }   
    }
}





