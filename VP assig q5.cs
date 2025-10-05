using System;
public class MultiplicationTableGenerator
{
    
    public void GenerateTable()
    {
        Console.WriteLine("--- Multiplication Table Generator (For Loop) ---");
        Console.Write("Enter the number for which you want the multiplication table: ");

        
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine($"\nMultiplication Table for {num} (up to 10):");

           
            for (int i = 1; i <= 10; i++)
            {
               
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a valid whole number.");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
}
public class Program
{
    
    public static void Main(string[] args)
    {
        MultiplicationTableGenerator generator = new MultiplicationTableGenerator();
        bool continueRunning = true;

        
        while (continueRunning)
        {
            generator.GenerateTable();

            Console.Write("Do you want to generate another multiplication table? Enter Y to continue, or any other key to exit: ");
            string response = Console.ReadLine();

            
            if (response == null || response.Trim().ToUpper() != "Y")
            {
                continueRunning = false;
            }
            Console.WriteLine("\n===========================================\n");
        }

        Console.WriteLine("Thank you for using the Multiplication Table Generator.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
