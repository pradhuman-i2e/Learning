// if statemnt , else if and else statemnet use


class Conditions
{
    public static void ShowConditions()
    {
        Console.WriteLine("Enter your score (0-100):");

       
        int score = Convert.ToInt32(Console.ReadLine());

        
        if (score >= 90)
        {
            Console.WriteLine("You got an A grade!");
        }
        else if (score >= 75)
        {
            Console.WriteLine("You got a B grade!");
        }
        else if (score >= 50)
        {
            Console.WriteLine("You got a C grade.");
        }
        else
        {
            Console.WriteLine("You failed the exam.");
        }
    }
}