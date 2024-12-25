/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 08
*/

using System;

class Lab8B
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Please enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        Console.WriteLine($"I have {rows} rows and {cols} columns. I need to fill-up {rows * cols} spaces.");

        int[,] array2D = new int[rows, cols];

        
        int value = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = value;
                value++;
            }
        }

       
        Console.WriteLine("The {0}x{1} array:", rows, cols);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array2D[i, j] + "|");
            }
            Console.WriteLine();
        }

        
        int[] array1D = new int[rows * cols];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array1D[index] = array2D[i, j];
                index++;
            }
        }

      
       
    }
}





