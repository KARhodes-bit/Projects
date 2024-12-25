/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab:11
*/
using System;


	public class Lab11B
	{
        public static void Main(string[] args)
        {
        
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();
        bool upperCasePresent = false;
        bool digitPresent = false;
        bool minLength = false;

        if (password.Length >= 8)
        {
            minLength = true;
        }
        for (int i = 0; i < password.Length; i++)
        {
            if (password[i] >= 'A' && password[i] <= 'Z')
            {
                upperCasePresent = true;
            }
            else if (password[i] >= '0' && password[i] <= '9')
            {
                digitPresent = true;
            }
        }
        if (upperCasePresent == true && digitPresent == true && minLength == true)
        {
            Console.Write("Valid password\n\n");
        }
        else
        {
            Console.Write("Invalid password\n\n");
        }
        Console.Write("Program Ends");

        }
    }


