/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab:10
*/

using System;

class Lab10A
{
    
    public static int min(int x, int y) 
    {
        if (x < y)
            return x;
        else
            return y;
    }
    public static int max(int x, int y) 
    {
        if (x > y)
            return x;
        else
            return y;
    }
    public static double average(int x, int y) 
    {
        double res = ((double)x + (double)y) / 2;
        return res; 
    }
    static void Main() 
    {
        String one, two; 
        int x, y;
        Console.Write("Enter number 1: "); 
        one = Console.ReadLine();
        x = Convert.ToInt32(one);
        Console.Write("Enter number 2: "); 
        two = Console.ReadLine();
        y = Convert.ToInt32(two);
        Console.WriteLine("Min is {0}", min(x, y)); 
        Console.WriteLine("Max is {0}", max(x, y)); 
        Console.WriteLine("Average is {0}", average(x, y));
    }
      
} 

    
