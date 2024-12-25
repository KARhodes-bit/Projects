/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 7
*/

using System;

class Lab7C
{
    static void Main(string[] args)
    {
        {
            
            Console.Write("Please enter a value for the size: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("This is the requested "+ size+ "x" + size+  " right-triangle:");
            for (int row = 0; row < size; row++)
            {
                for (int l = 0; l < size; l++)
                {
                    if (l >= size - row - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}