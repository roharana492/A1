using System;

public class NaturalNumberSummer
{
    public void CalculateSum()
    {
        Console.WriteLine("--- Sum of Natural Numbers (For Loop) ---");
        Console.Write("Enter a positive whole number (n) to calculate the sum from 1 to n: ");

       
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            
            long sum = 0;

           
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"\nCalculation: 1 + 2 + ... + {n}");
            Console.WriteLine($"Result: The total sum is {sum}");
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a positive whole number.");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        NaturalNumberSummer summer = new NaturalNumberSummer();
        bool continueRunning = true;

        while (continueRunning)
        {
            summer.CalculateSum();

            Console.Write("Do you want to calculate another sum? Enter Y to continue, or any other key to exit: ");
            string response = Console.ReadLine();

            if (response == null || response.Trim().ToUpper() != "Y")
            {
                continueRunning = false;
            }
            Console.WriteLine("\n===========================================\n");
        }

        Console.WriteLine("Thank you for using the Natural Number Sum Calculator.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
