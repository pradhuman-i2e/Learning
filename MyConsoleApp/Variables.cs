
class Variables
{
    public static void ShowVariables()
    {
        string name = "Pradhuman";
        string company = "I2E Consulting";
        int age = 21;
        double stipend = 5000;
        char grade = 'A';
        bool isWorking = true;
        const string department = "Cloud and Custom";
       
        int x = 5, y = 6, z = 50;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Company: {company}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Salary: {stipend}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Working: {isWorking}");
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Sum of x, y, and z: {x + y + z}");
      
    }
}
