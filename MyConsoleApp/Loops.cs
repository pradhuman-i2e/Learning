class LoopsExample
{  public static void WhileLoop()
    {
        Console.WriteLine("While Loop Example:");
        int i = 0; 
 while (i < 5)
        {
            Console.WriteLine(i); 
            i++; 
        }
    }
    public static void DoWhileLoop()
    {
        Console.WriteLine("\nDo-While Loop Example:");
        int i = 0; 

 do
        {
            Console.WriteLine(i); 
            i++; 
        } while (i < 5); 
    }
    public static void ForLoop()
    {
        Console.WriteLine("\nFor Loop Example:");
        
        for (int i = 0; i <= 10; i = i + 2) 
        {
            Console.WriteLine(i); 
        }
    }
}
