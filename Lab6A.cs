/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 6
*/

using System;

class Lab6A
{
    static void Main(string[] args)
    {
        int  largenum = 0;
        Console.WriteLine("Please enter 10 numbers and this program will display the largest. ");
        for(int i =1; i<=10; i++)
        {
            Console.WriteLine("Please enter number " + i+ ": ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value > largenum)
            {
                largenum = value;
            }
    
        }
        Console.WriteLine("The largest number was " + largenum);
    }
}


