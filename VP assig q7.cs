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


public class NumberReverser
{
    public void ReverseNumber()
    {
        Console.WriteLine("--- 2. Reverse a Number (While Loop) ---");
        Console.Write("Enter a whole number to reverse its digits (e.g., 123): ");

        // Safely read and parse the user input.
        if (int.TryParse(Console.ReadLine(), out int n))
        {
           
            int originalNumber = n;
            int sign = Math.Sign(n); 
            int number = Math.Abs(n); 

           
            long reversedNumber = 0;

            
            while (number > 0)
            {
                int remainder = number % 10; 
                reversedNumber = (reversedNumber * 10) + remainder; 
                number /= 10; 
            }

           
            long finalReversedNumber = reversedNumber * sign;

            Console.WriteLine($"\nResult: The reverse of {originalNumber} is {finalReversedNumber}.");
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
        FactorialCalculator calculator = new FactorialCalculator();
        NumberReverser reverser = new NumberReverser();
        bool continueRunning = true;

      
        while (continueRunning)
        {
            
            calculator.CalculateFactorial();
            reverser.ReverseNumber();

            Console.Write("Do you want to run both programs again? Enter Y to continue, or any other key to exit: ");
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

