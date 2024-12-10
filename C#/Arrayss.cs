class ArrayExamples
{
    //Access the array by there index
    public static void ShowArrayAccess()
    {
        Console.WriteLine("Accessing Array Elements:");
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        Console.WriteLine(cars[0]); 
    }

    // Inserting loop to access array elements
    public static void LoopThroughArray()
    {
        Console.WriteLine("\nLooping Through Array:");
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        for (int i = 0; i < cars.Length; i++) 
        {
            Console.WriteLine(cars[i]); 
        }
    }

    // Sorting an array and displaying its elements
    public static void SortAndDisplayArray()
    {
        Console.WriteLine("\nSorting and Displaying Array:");
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        Array.Sort(cars); // Sort the array alphabeticall like BMW first and volvo last

        foreach (string car in cars) 
        {
            Console.WriteLine(car);
        }
    }
}
