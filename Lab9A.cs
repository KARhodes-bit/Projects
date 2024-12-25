/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 9
*/

using System;

class Lab9A
{
    static void Main(string[] args)
    {
      const int SIZE = 10;
      int[] nums = new int[SIZE];
      int target;

     Console.WriteLine("Please enter " + SIZE + " numbers:\n");
     for (int i = 0; i < SIZE; i++)
     {
        Console.Write("Integer " + (i + 1) + ": ");
        nums[i] = int.Parse(Console.ReadLine());
     }

        Console.Write("What is the target number: ");
        target = int.Parse(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < SIZE; i++)
        {
          if (nums[i] == target)
          {
            found = true;
            break;
          }
        }

        Console.WriteLine("The target is " + (found ? "in" : "not in") + " the set.");
    }
}