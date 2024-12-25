/*
    Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Kendres Rhodes
Lab#: 3
*/

using System;
namespace Lab3
{
	public class Lab3B
	{
        public static void Main(string[] args)
        {

            float c1h, c1g, c2h, c2g, c3h, c3g, c4h, c4g, gpa, Total_hours, Total_quality_points;

            Console.Write("Course 1 hours: ");
            c1h = float.Parse(Console.ReadLine());
            Console.Write("Grade for course 1: ");
            c1g = float.Parse(Console.ReadLine());
            Console.Write("Course 2 hours: ");
            c2h = float.Parse(Console.ReadLine());
            Console.Write("Grade for course 2: ");
            c2g = float.Parse(Console.ReadLine());
            Console.Write("Course 3 hours: ");
            c3h = float.Parse(Console.ReadLine());
            Console.Write("Grade for course 3: ");
            c3g = float.Parse(Console.ReadLine());
            Console.Write("Course 4 hours: ");
            c4h = float.Parse(Console.ReadLine());
            Console.Write("Grade for course 4: ");
            c4g = float.Parse(Console.ReadLine());

            Total_hours = c1h + c2h + c3h + c4h;
            Console.WriteLine("Total hours is: " + Total_hours);
            Total_quality_points = c1h * c1g + c2h * c2g + c3h * c3g + c4h * c4g;
            Console.WriteLine("Total quality points is: " + Total_quality_points);
            gpa = Total_quality_points / Total_hours;
            Console.WriteLine("Your GPA for this semester is " + gpa);



        }
    }
}

