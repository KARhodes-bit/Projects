/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 12
*/

using System;


class chair
{
    
    public int numOfLegs;
    public bool rolling;
    public string material;
  
    public chair(int numOfLegs, bool rolling, string material)
    {
        this.numOfLegs = numOfLegs;
        this.rolling = rolling;
        this.material = material;
    }
}

class Lab12A
{
    static void Main()
    {
        //giving instruction to the user and taking input
        Console.WriteLine("You are about to create a chair.");
        Console.Write("How many legs does your chair have: ");
        int numOfLegs = Convert.ToInt32(Console.ReadLine());
        Console.Write("Is your chair rolling (true/false): ");
        bool rolling = bool.Parse(Console.ReadLine());
        Console.Write("What is your chair made of: ");
        string material = Console.ReadLine();
        chair obj = new chair(numOfLegs, rolling, material);

        
        if (rolling)
        {
            Console.WriteLine($"\nYour chair has {obj.numOfLegs} legs, is rolling, and is made of {obj.material}.");
        }
        else
        {
            Console.WriteLine($"\nYour chair has {obj.numOfLegs} legs, is rolling, and is made of {obj.material}.");
        }

        Console.WriteLine("\nThis program is going to change that.");
        
        obj.numOfLegs = 4;
        obj.rolling = false;
        obj.material = "wood";
        
        if (rolling)
        {
            Console.WriteLine($"\nYour chair has {obj.numOfLegs} legs, is  not rolling, and is made of {obj.material}.");
        }
        else
        {
            Console.WriteLine($"\nYour chair has {obj.numOfLegs} legs, is not rolling, and is made of {obj.material}.");
        }

    }
}