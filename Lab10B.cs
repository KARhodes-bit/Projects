/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab:10
*/

using System;

class Lab10B
{
    
    static bool isValid(double width, double height)
    {
        return width + height >= 30;
    }
    
    static double Area(double width, double height)
    {
        return width * height;
    }
   
    static double Perimeter(double width, double height)
    {
        return 2 * (width + height);
    }
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            if (isValid(width, height))
            {
                Console.WriteLine("This is a valid rectangle");
                Console.WriteLine("The area is: " + Area(width, height));
                Console.WriteLine("The perimeter is: " + Perimeter(width, height));
            }
            else
            {
                Console.WriteLine("This is an invalid rectangle\n");
            }
            Console.Write("Do you want to enter another width and height (Y/N)?: ");
            string choice = Console.ReadLine();
            if (choice == "Y")
            {
                continue;
            }
            else
            {
                Console.Write("Program Ends");
                break;
            }
        }
    }

}


