// class Person
// {
//     public string Name; // Public meansaccessible from anywhere
//     private int Age = 21; // Private means accessible only within this class
//     protected string FavoriteCar = "Scorpio Z8"; // Protected meanss accessible in this class and derived classes

//     public void DisplayPublicInfo()
//     {
//         Console.WriteLine("Name: " + Name);
//         Console.WriteLine("Age: " + Age); // accessing private variable within the class
//     }
// }

// class FamilyMember : Person
// {
//     public void ShowProtectedInfo()
//     {
//         Console.WriteLine("Favorite Car: " + FavoriteCar); // Accessing protected variable
//     }
// }