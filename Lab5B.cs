/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 5
*/

using System;

class Lab5B
{
    static void Main(string[] args)
    {
      int userchoice, userchoice_2;
      
        Console.Write("Enter an integer: ");
        userchoice = Convert.ToInt32(Console.ReadLine());
        if(userchoice % 2 == 0)
        {
            userchoice_2 = 2;
           
        }
       else if (userchoice % 3 == 0)
        {
            userchoice_2 = 3;
            
        }
       else if (userchoice % 5 == 0)
        {
            userchoice_2 = 5;
            
        }
        else
        {
            userchoice_2 = -1;
            
        }
        switch (userchoice_2)
        {
            case 2:
                Console.WriteLine("This number is divisible by 2");
                break;
            case 3:
                Console.WriteLine("This number is divisible by 3");
                break;
            case 5:
                Console.WriteLine("This number is divisible by 5");
                break;
            default:
                Console.WriteLine("This number is undetermined");
                break;

        }

    }
}


