
using System;
public class FactorialCalculator
{
    
    public void CalculateFactorial()
    {
        Console.WriteLine("--- 1. Factorial Calculator (While Loop) ---");
        Console.Write("Enter a non-negative whole number (n) to calculate its factorial (n!): ");

        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            if (n == 0)
            {
                Console.WriteLine("\nResult: 0! is 1.");
            }
            else
            {
                
                long factorial = 1;
                int currentNumber = n;

                while (currentNumber > 0)
                {
                    factorial *= currentNumber;
                    currentNumber--; 
                }

                Console.WriteLine($"\nCalculation: {n}! = {factorial}");
            }
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a non-negative whole number (0 or greater).");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
}
public class Program
{
    
    public static void Main(string[] args)
    {
        FactorialCalculator calculator = new FactorialCalculator();
        bool continueRunning = true;

        
        while (continueRunning)
        {
            calculator.CalculateFactorial();

            Console.Write("Do you want to calculate another factorial? Enter Y to continue, or any other key to exit: ");
            string response = Console.ReadLine();

            
            if (response == null || response.Trim().ToUpper() != "Y")
            {
                continueRunning = false;
            }
            Console.WriteLine("\n===========================================\n");
        }

       
        Console.WriteLine("Thank you for using the Factorial Calculator.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
