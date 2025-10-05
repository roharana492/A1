using System; 
public class NumberChecker
{
    public void CheckEvenOrOdd()
    {
        Console.WriteLine("--- 1. Even or Odd Checker ---");
        Console.Write("Please enter a whole number: ");

        
        string input = Console.ReadLine();

        int number;

        if (int.TryParse(input, out number))
        {
            
            if (number % 2 == 0)
            {
                Console.WriteLine($"\nResult: The number {number} is EVEN.");
            }
            else
            {
                Console.WriteLine($"\nResult: The number {number} is ODD.");
            }
        }
        else
        {
            
            Console.WriteLine("\nError: Invalid input. Please enter a valid whole number (e.g., 42 or -5).");
        }

        Console.WriteLine("------------------------------\n");
    }
}

public class Program
{
    
    public static void Main(string[] args)
    {
        
        NumberChecker checker = new NumberChecker();

        checker.CheckEvenOrOdd();

        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
