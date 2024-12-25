/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 12
*/

using System;

class Dog
{
   
    public int age;
    public double weight;
    public string name;
    public string furColor;
    public string breed;

    
    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public void Rename(string newName)
    {
        name = newName;
    }

    public void Eat(double amount)
    {
        weight += amount;
    }
}

class Lab12B
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();

        Console.WriteLine("You are about to create a dog ");
        Console.Write("How old is the dog: ");
        myDog.age = int.Parse(Console.ReadLine());

        Console.Write("How much does the dog weigh: ");
        myDog.weight = double.Parse(Console.ReadLine());

        Console.Write("What is the dog's name: ");
        myDog.name = Console.ReadLine();

        Console.Write("What color is the dog: ");
        myDog.furColor = Console.ReadLine();

        Console.Write("What breed is the dog: ");
        myDog.breed = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"{myDog.name} is a {myDog.age} year old {myDog.furColor} {myDog.breed} that weighs {myDog.weight} lbs.");
        Console.WriteLine();
        myDog.Bark();

        Console.Write($"{myDog.name} is hungry, how much should he eat: ");
        double amountToEat = double.Parse(Console.ReadLine());
        myDog.Eat(amountToEat);

        Console.Write($"{myDog.name} isn't a very good name. What should they be renamed to: ");
        string newName = Console.ReadLine();
        myDog.Rename(newName);
        Console.WriteLine();

        Console.WriteLine($"{myDog.name} is a {myDog.age} year old {myDog.furColor} {myDog.breed} that weighs {myDog.weight} lbs.");

        Console.ReadLine(); 
    }
}



