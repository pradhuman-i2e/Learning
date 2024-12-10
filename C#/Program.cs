// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// // THIS IS THE ENTRY POINT OF THE CONSOLE APPLICATION


// /*
// class Program{
//     public static void Main(string[] args){
//         // Console.WriteLine("Pradhuman Singh Chaudhary");

//         // Prompt user for username
//         Console.WriteLine("Enter username:");

//         // Read input from the user and store it in 'userName' variable
//         string userName = Console.ReadLine();

//         // Output the entered username
//         Console.WriteLine("Username is: " + userName);
//     }
// }
// */

// // Variables and Data Types

// /*
// class Program{
//     public static void Main(string[] args){
//         Variables.ShowVariables();  // Call method from 'Variables' class to show variable examples
//     }
// }
// */

// // Assignment, comparison and logical operators

// /*
// class Program{
//     public static void Main(string[] args){
//         Operator.ShowOperators();  // Call method from 'Operator' class to demonstrate operators
//     }
// }
// */

// // Strings - Using the Program class directly without partial class
// class Program    {public static void Main(string[] args)

//     {StringExamples.ShowStringExamples();
//     }}

// if else statemeent

// class Program
// {
//     public static void Main(string[] args)
//     {

//         Conditions.ShowConditions();
//     }
// }

// switch case
// class Program
// {
//     public static void Main(string[] args)
//     {
//         SwitchCase.ShowDay();
//     }
// }

// loop do-while,forloops

//class Program
//{
//    public static void Main(string[] args)
//    {
//        LoopsExample.WhileLoop();
//        LoopsExample.DoWhileLoop();
//        LoopsExample.ForLoop();
//    }
//}


//array
// class Program
//{
//    public static void Main(string[] args)
//    {
//        ArrayExamples.ShowArrayAccess();
//        ArrayExamples.LoopThroughArray();
//        ArrayExamples.SortAndDisplayArray();
//    }
//}


//methods
// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Call methods with a single parameter
//         MethodExamples.PrintName("Liam");
//         MethodExamples.PrintName("Jenny");
//         MethodExamples.PrintName("Anja");
//         // Call methods with multiple parameters
//         MethodExamples.PrintNameAndAge("Liam", 5);
//         MethodExamples.PrintNameAndAge("Jenny", 8);

//         MethodExamples.PrintNameAndAge("Anja", 31);
//         // Call method with a default parameter
//         MethodExamples.PrintCountry("Sweden");
//         MethodExamples.PrintCountry("India");
//         MethodExamples.PrintCountry(); // Uses the default value
//         MethodExamples.PrintCountry("USA");
//         // Call method that returns a value
//         int result = MethodExamples.AddNumbers(5, 3);
//         Console.WriteLine($"The sum is: {result}");
//         int result1 = MethodExamples.PlusMethodInt(8, 5); 
//         double result2 = MethodExamples.PlusMethodDouble(4.3, 6.26);
//         // Display the results
//         Console.WriteLine("Hello, my name is Pradhuman!");
//         Console.WriteLine("The sum of integers is: " + result1);
//         Console.WriteLine("The sum of doubles is: " + result2);
//     }
// }



// Classes and Objects

// class Program
// {
//     public static void Main(string[] args)
//     {

//         Car myCar = new Car();


//         Console.WriteLine("The color of the car is: " + myCar.color);
//     }
// }

// class Car
// {
//     public string color = "Red";
// }


// Construvtors

// class Program
// {
//     static void Main(string[] args)
//     {
//         Car myCar = new Car("Pradhuman", "Scorpio Z8", "Diesel");
//         Console.WriteLine("Owner: " + myCar.owner);
//         Console.WriteLine("Car Model: " + myCar.model);
//         Console.WriteLine("Fuel Type: " + myCar.fuelType);
//     }
// }

// class Car
// {
//     public string owner;
//     public string model;
//     public string fuelType;

//     public Car(string ownerName, string carModel, string fuel)
//     {
//         owner = ownerName;
//         model = carModel;
//         fuelType = fuel;
//     }
// }


// ACCESS Modifieers
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Person pradhuman = new Person();
//         pradhuman.Name = "Pradhuman"; // Accessing public variable
//         pradhuman.DisplayPublicInfo(); // Accessing public method

//         FamilyMember familyMember = new FamilyMember();
//         familyMember.ShowProtectedInfo(); // Accessing protected info via a derived class
//     }
// }


//Inheritance
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Details pradhumanDetails = new Details();
//         pradhumanDetails.DisplayInfo(); // access method from base class
//         pradhumanDetails.ShowCar(); // access method from derived class
//     }
// }


//Polymorphism 
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Vehicle myVehicle;

//         myVehicle = new Car();
//         myVehicle.DisplayDetails();

//         Console.WriteLine();

//         myVehicle = new Bike();
//         myVehicle.DisplayDetails();
//     }
// }


// abstraction or interface




// Single Responsibility Principle



// class Program
// {
//     public static void Main(string[] args)
//     {
//         UserInput userInput = new UserInput();
//         Report reportGenerator = new Report();

//         string userData = userInput.GetUserData();
//         reportGenerator.GenerateReport(userData);
//     }
// }


// Open and closed principle

//class Program
//{
//    public static void Main(string[] args)
//    {
//        NewCar petrolCar = new PetrolCar();
//        NewCar electricCar = new ElectricCar();

//        petrolCar.Start();
//        electricCar.Start();
//    }
//}







