using System;
using System.Linq;
public class ArraySearcher
{
    private const int ArraySize = 5; 

    public void SearchElement()
    {
        Console.WriteLine($"--- 1. Array Search: Find Element in Array ({ArraySize} Integers) ---");
        int[] numbers = new int[ArraySize];

     
        Console.WriteLine($"Please enter {ArraySize} whole numbers to populate the array:");
        for (int i = 0; i < ArraySize; i++)
        {
            Console.Write($"Enter number {i + 1}/{ArraySize}: ");
            if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("\nError: Invalid input. Please only enter whole numbers. Cannot proceed.");
                return;
            }
        }

        Console.WriteLine($"\nArray created: [{string.Join(", ", numbers)}]");

       
        Console.Write("Enter the number you want to search for: ");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("\nError: Invalid input for search target.");
            return;
        }

     
        int foundIndex = -1;

       
        for (int i = 0; i < ArraySize; i++)
        {
            if (numbers[i] == target)
            {
                foundIndex = i;
                break; 
            }
        }

        
        Console.WriteLine("\n--- Search Results ---");
        if (foundIndex != -1)
        {
            Console.WriteLine($"Result: The number {target} was found at index position {foundIndex}.");
        }
        else
        {
            Console.WriteLine($"Result: The number {target} was NOT found in the array.");
        }

        Console.WriteLine("-------------------------------------------\n");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ArraySearcher searcher = new ArraySearcher();
        bool continueRunning = true;

        while (continueRunning)
        {
            searcher.SearchElement();

            Console.Write("Do you want to run the array search program again? Enter Y to continue, or any other key to exit: ");
            string response = Console.ReadLine();

        
            if (response == null || response.Trim().ToUpper() != "Y")
            {
                continueRunning = false;
            }
            Console.WriteLine("\n===========================================\n");
        }

     
        Console.WriteLine("Thank you for using the C# Assignment Programs.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

