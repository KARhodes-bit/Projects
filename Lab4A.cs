/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Kendres Rhodes
Lab#: 4
*/
using System;

namespace Lab4
{
    public class Lab4A
    {
        public static void Main(string[] args)
        {
            double exam_score;

            Console.Write("Enter the score of your exam: ");
            exam_score = Convert.ToDouble(Console.ReadLine());
            if (exam_score >= 97.5 && exam_score <= 100)
            {
                Console.WriteLine("Letter grade is: A+");
            }
            else if (exam_score >= 94.5 && exam_score < 97.5)
            {
                Console.WriteLine("Letter grade is: A");
            }
            else if (exam_score >= 91.5 && exam_score < 94.5)
            {
                Console.WriteLine("Letter grade is: A-");
            }
            else if (exam_score >= 89.5 && exam_score < 91.5)
            {
                Console.WriteLine("Letter grade is: B+");
            }
            else if (exam_score >= 85.5 && exam_score < 88.5)
            {
                Console.WriteLine("Letter grade is: B");
            }
            else if (exam_score >= 82.5 && exam_score < 85.5)
            {
                Console.WriteLine("Letter grade is: B-");
            }
            else if (exam_score >= 79.5 && exam_score < 82.5)
            {
                Console.WriteLine("Letter grade is: C+");
            }
            else if (exam_score >= 77.5 && exam_score < 79.5)
            {
                Console.WriteLine("Letter grade is: C");
            }
            else if (exam_score >= 73.5 && exam_score < 76.5)
            {
                Console.WriteLine("Letter grade is: C-");
            }
            else if (exam_score >= 70.5 && exam_score < 73.5)
            {
                Console.WriteLine("Letter grade is: D+");
            }
            else if (exam_score >= 67.5 && exam_score < 70.5)
            {
                Console.WriteLine("Letter grade is: D");
            }
            else if (exam_score >= 64.5 && exam_score < 67.5)
            {
                Console.WriteLine("Letter grade is: D-");
            }
            else if (exam_score >= 0 && exam_score < 64.5)
            {
                Console.WriteLine("Letter grade is: F");
            }

        }
    }
}


