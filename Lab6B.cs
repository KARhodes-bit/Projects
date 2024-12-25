/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 6
*/

using System;

class Lab6B
{
    static void Main(string[] args)
    {
        float range = 0;
        Random rnd = new Random();
        int value = rnd.Next(0, 1000);
        Console.WriteLine("Enter a number between 1 and 1000: ");
        int userinput = Convert.ToInt32(Console.ReadLine());
        int number = 1;
        while (value != userinput)
        {
            Console.WriteLine("My guess was " + value);
            value = rnd.Next(0, 1000);
            number++;
            
        }
        
        Console.WriteLine("I guessed the number was " + userinput + " and it only took me " + number +  " guesses");
    }

}




