/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab#:2
*/


class Lab2A
{
    static void Main(string[] args)
    {
        string name, another_name, verb, adverb;
        Console.WriteLine("Enter a name: ");
        name=Console.ReadLine();
        Console.WriteLine("Enter another name: ");
        another_name = Console.ReadLine();
        Console.WriteLine("Enter a verb: ");
        verb = Console.ReadLine();
        Console.WriteLine("Enter an adverb: ");
        adverb = Console.ReadLine();

        Console.Write("Once upon a time, there was a person named" + name + "who had a child named" + another_name +". This child would" + verb +" " + adverb + "while singing to strangers.");

    }
}
