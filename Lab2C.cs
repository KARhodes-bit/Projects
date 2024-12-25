/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab#:2
*/
using System;

	public class Lab2C
	{
		static void Main(string[] args)
		{
			int area, perimeter, width, height;
			Console.WriteLine("Enter a width: ");
        width = Convert.ToInt32(Console.ReadLine);
			Console.WriteLine("Enter a height: ");
			height = Convert.ToInt32(Console.ReadLine);
			area = height * width;
			Console.WriteLine("The area is "+ area);
			perimeter = 2 * (height + width);
			Console.WriteLine("The perimeter is " + perimeter);
			
		}
	}
