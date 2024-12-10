class MethodExamples
{
    // method with a single parameter
    public static void PrintName(string fname)
    {
        Console.WriteLine(fname + " Refsnes");
    }

    // method with multiple param
    public static void PrintNameAndAge(string fname, int age)
    {
        Console.WriteLine(fname + " is " + age);
    }

    // method with a default param
    public static void PrintCountry(string country = "Norway")
    {
        Console.WriteLine(country);
    }

    // method with a return value
    public static int AddNumbers(int x, int y)
    {
        return x + y;
    }

       public static int PlusMethodInt(int x, int y)
    {
        return x + y;
    }

    // Method to add two doubles
    public static double PlusMethodDouble(double x, double y)
    {
        return x + y;
    }
}