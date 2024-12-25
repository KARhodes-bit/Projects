/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 9
*/

using System;

class Lab9B
{
    static void Main(string[] args)
    {

        const int arraySize = 11;
        int[] numbers = new int[arraySize];

      
        Console.WriteLine("Please enter {0} numbers:", arraySize);
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Integer {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort(numbers);

        Console.Write("What is the target number: ");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The sorted set is: {0}", string.Join(" ", numbers));
        Console.WriteLine();




        int index = BinarySearch(numbers, target);

      
        if (index >= 0)
        {
            Console.WriteLine("The target is in the set.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The target is not in the set.");
            Console.WriteLine();
        }

        Console.ReadLine();
    }

    static void BubbleSort(int[] numbers)
    {
        int temp;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
    }
            

    static int BinarySearch(int[] numbers, int target)
    {
        int low = 0;
        int high = numbers.Length - 1;
        int mid;
       
        while (low <= high)
        {
            mid = (low + high) / 2;
            
            Console.WriteLine("Low is {0}", low);
            Console.WriteLine();
            Console.WriteLine("High is {0}", high);
            Console.WriteLine();
            Console.WriteLine("Mid is {0}", mid);
            Console.WriteLine();
            Console.WriteLine("Searching");
            Console.WriteLine();
            if (numbers[mid] == target)
            {
                return mid;
            }
            else if (numbers[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;
    }

}