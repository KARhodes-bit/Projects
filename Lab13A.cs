/*
Class: CSE 1321L
Section: Online 15620
Term: Spring 2024
Instructor: Manosmi Gundu
Name:Kendres Rhodes
Lab: 13
*/

using System;

class BuildingBluePrint
{
    private int numStories;
    private int numApartments;
    private float occupancyRate;
    private bool fullyOccupied;

    public float OccupancyRate
    {
        get { return this.occupancyRate; }
        set
        {
            if (value >= 0 && value <= 1)
            {
                this.occupancyRate = value;
                this.fullyOccupied = this.occupancyRate == 1;
            }
        }
    }

    public int NumStories
    {
        get { return this.numStories; }
    }

    public int NumApartments
    {
        get { return this.numApartments; }
    }

    public bool FullyOccupied
    {
        get { return this.fullyOccupied; }
    }

    public BuildingBluePrint() : this(10, 20, 1.0f)
    {

    }

    public BuildingBluePrint(int numStories, int numApartments, float occupancyRate)
    {
        this.numStories = numStories;
        this.numApartments = numApartments;
        this.OccupancyRate = occupancyRate;
    }
}

class Lab13A
{
    static void Main(string[] args)
    {
        BuildingBluePrint buildingOne = new BuildingBluePrint();
        BuildingBluePrint buildingTwo = new BuildingBluePrint(30, 30, 0.75f);

        Console.WriteLine("Year 2020:");
        Console.WriteLine("Building 1 has " + buildingOne.NumStories + " floors, " + buildingOne.NumApartments + " apartments, and is "
            + buildingOne.OccupancyRate.ToString("P") + " occupied. Full? " + buildingOne.FullyOccupied);
        Console.WriteLine("Building 2 has " + buildingTwo.NumStories + " floors, " + buildingTwo.NumApartments + " apartments, and is "
           + buildingTwo.OccupancyRate.ToString("P") + " occupied. Full? " + buildingTwo.FullyOccupied);
        Console.WriteLine();
        Console.WriteLine("Many years pass. ");
        Console.WriteLine();

        buildingOne.OccupancyRate = 0.0f;
        buildingTwo.OccupancyRate = 1.0f;

        Console.WriteLine("Year 2043:");
        Console.WriteLine("Building 1 has " + buildingOne.NumStories + " floors, " + buildingOne.NumApartments + " apartments, and is "
            + buildingOne.OccupancyRate.ToString("P") + " occupied. Full? " + buildingOne.FullyOccupied);
        Console.WriteLine("Building 2 has " + buildingTwo.NumStories + " floors, " + buildingTwo.NumApartments + " apartments, and is "
           + buildingTwo.OccupancyRate.ToString("P") + " occupied. Full? " + buildingTwo.FullyOccupied);

        Console.WriteLine();
        Console.WriteLine("Looks like people prefer taller buildings.");
        Console.ReadKey();
    }
}
