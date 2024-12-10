

class StringExamples
{
    public static void ShowStringExamples()
    {
        string name = "Pradhuman";
        string company = "I2E Consulting";
        string department = "Cloud and custom";

        // String Interpolation
        string interpolatedMessage = $"Hello, {name}! Welcome to {company}'s {department} team.";
        Console.WriteLine("String Interpolation is the Methoda used Here");
        Console.WriteLine(interpolatedMessage);

        // String Concatenation
        string concatenatedMessage = "Hello, " + name + "! " + "Welcome to " + company + ".";
        Console.WriteLine("\nString Concatenation is Used here");
        Console.WriteLine(concatenatedMessage);

        // Accessing String Characters
        Console.WriteLine("\nAccessing String Characters is Used ");
        Console.WriteLine($"First character in name: {name[0]}");
        Console.WriteLine($"Last character in company: {company[company.Length - 1]}");

        // String Length
        Console.WriteLine($"\nThe length of the name '{name}' is: {name.Length} and here the Lenth Method is Used");
    }
}
