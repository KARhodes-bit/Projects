/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Kendres Rhodes
Lab#: 1
*/
using System;
// Program Lab1C.cs
public class Lab1C
{
 // Calculates fuel efficiency based on values entered by the user.
 public static void Main (String[] args)
 {
 int miles;
 double gallons, mpg;
 Console.Write ("Enter the number of miles: ");
 miles = Convert.ToInt32(Console.ReadLine());

 Console.Write ("Enter the gallons of fuel used: ");
 gallons = Convert.ToInt32(Console.ReadLine());

 mpg = miles / gallons;
 Console.WriteLine ("Miles Per Gallon: " + mpg);
 }
}
