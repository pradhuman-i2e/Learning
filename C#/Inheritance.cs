class Person
{
    public string Name = "Pradhuman";
    public int Age = 21;

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Details : Person
{
    public string FavoriteCar = "Scorpio Z8";

    public void ShowCar()
    {
        Console.WriteLine("Favorite Car: " + FavoriteCar);
    }
}
