using System;

public class ArrayAnalyzer
{
   
    public void AnalyzeArray()
    {
        Console.WriteLine("--- 1. Array Summation and Average (Arrays & Loops) ---");

        
        int[] numbers = { 10, 25, 40, 5, 20 };
        Console.WriteLine($"Initialized Array: [{string.Join(", ", numbers)}]");

        int sum = 0;
        Console.WriteLine("Calculating sum using a 'for' loop...");
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i]; 
        }

        
        int count = numbers.Length;
        
        double average = (double)sum / count;

        Console.WriteLine($"\nTotal Sum: {sum}");
        Console.WriteLine($"Array Count: {count}");
        Console.WriteLine($"Average Value: {average:F2} (Rounded to two decimal places)");

        Console.WriteLine("--------------------------------------------------\n");
    }
}


public class Calculator
{
    
    public void RunCalculator()
    {
        Console.WriteLine("--- 2. Simple Console Calculator (Switch-Case) ---");

        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input for the first number.");
            Console.WriteLine("--------------------------------------------------\n");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input for the second number.");
            Console.WriteLine("--------------------------------------------------\n");
            return;
        }

        double result = 0;
        bool isValidOperation = true;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
              
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("\nError: Division by zero is not allowed.");
                    isValidOperation = false;
                }
                break;
            default:
                Console.WriteLine("\nError: Invalid operator entered. Please use +, -, *, or /.");
                isValidOperation = false;
                break;
        }

        if (isValidOperation)
        {
            Console.WriteLine($"\nResult: {num1} {op} {num2} = {result}");
        }

        Console.WriteLine("--------------------------------------------------\n");
    }
}


public class Program
{
    
    public static void Main(string[] args)
    {
       
        ArrayAnalyzer analyzer = new ArrayAnalyzer();
        analyzer.AnalyzeArray();

        Calculator calculator = new Calculator();
        calculator.RunCalculator();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
