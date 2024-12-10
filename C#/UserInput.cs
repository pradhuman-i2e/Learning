class UserInput
{
    public string GetUserData()
    {
        Console.WriteLine("Enter your name:");
        string ?userInput = Console.ReadLine();
        
        if (string.IsNullOrEmpty(userInput))
        {
            return "Unknown User"; // Return a default value if the user input is empty or null
        }

        return userInput;
    }
}