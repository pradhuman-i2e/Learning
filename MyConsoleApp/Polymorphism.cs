class Vehicle
{
    public virtual void DisplayDetails()
    {
        Console.WriteLine("This is a vehicle.");
    }
}

class Car : Vehicle
{
    public string Model = "Scorpio Z8";
    public string OwnerSurname = "Chaudhary";

    public override void DisplayDetails()
    {
        Console.WriteLine("This is a car.");
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Owner's Surname: " + OwnerSurname);
    }
}

class Bike : Vehicle
{
    public string Model = "Royal Enfield";
    public string OwnerSurname = "Chaudhary";

    public override void DisplayDetails()
    {
        Console.WriteLine("This is a bike.");
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Owner's Surname: " + OwnerSurname);
    }
}

// abstract class Vehicle
// {
//     public abstract void DisplayDetails(); // Abstract method

//     public void StartEngine()
//     {
//         Console.WriteLine("The engine is starting...");
//     }
// }

// class Car : Vehicle
// {
//     public string Model = "Scorpio Z8";
//     public string OwnerName = "Pradhuman Chaudhary";

//     public override void DisplayDetails()
//     {
//         Console.WriteLine("Car Details:");
//         Console.WriteLine("Model: " + Model);
//         Console.WriteLine("Owner: " + OwnerName);
//     }
// }