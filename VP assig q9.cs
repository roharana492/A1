using System;
public class EvenOddCounter
{
    private const int ArraySize = 10;

   
    public void CountNumbers()
    {
        Console.WriteLine($"--- 1. Array: Count Even and Odd Numbers ({ArraySize} Integers) ---");
        int[] numbers = new int[ArraySize];
        int evenCount = 0;
        int oddCount = 0;
        bool validInput = true;

        
        Console.WriteLine($"Please enter {ArraySize} whole numbers to populate the array:");
        for (int i = 0; i < ArraySize; i++)
        {
            Console.Write($"Enter number {i + 1}/{ArraySize}: ");

         
            if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("\nError: Invalid input detected. Please only enter whole numbers. Cannot proceed.");
                validInput = false;
                break;
            }
        }

        if (validInput)
        {
            foreach (int number in numbers)
            {
                
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

          
            Console.WriteLine("\n--- Analysis Results ---");
            Console.WriteLine($"Total numbers entered: {ArraySize}");
            Console.WriteLine($"Even Count: {evenCount}");
            Console.WriteLine($"Odd Count: {oddCount}");
        }

        Console.WriteLine("-------------------------------------------\n");
    }
}

public class Program
{
   
    public static void Main(string[] args)
    {
        EvenOddCounter counter = new EvenOddCounter();
        bool continueRunning = true;

        
        while (continueRunning)
        {
            counter.CountNumbers();

            Console.Write("Do you want to run the program again? Enter Y to continue, or any other key to exit: ");
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

