/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 08
*/

using System;

class Lab8A
{
    static void Main(string[] args)
    {
        
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int[] additionArray = new int[5];

        Console.WriteLine("Please enter 5 integers for the first array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Integer " + (i + 1) + ": ");
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Please enter 5 integers for the second array:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Integer " + (i + 1) + ": ");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            additionArray[i] = arr1[i] + arr2[i];
        }
        Console.Write("The resulting sums are ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(additionArray[i] + "|");
        }
        Console.ReadKey();
    }
}

    


