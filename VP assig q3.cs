using System;
public class GradeEvaluator
{
   
    public void DetermineGrade()
    {
        Console.WriteLine("--- 1. Grade Evaluator (Conditionals) ---");
        Console.Write("Enter student marks (0-100): ");

        if (int.TryParse(Console.ReadLine(), out int marks) && marks >= 0 && marks <= 100)
        {
            string grade;

            if (marks >= 85)
            {
                grade = "A+";
            }
            else if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 70) 
            {
                grade = "B";
            }
            else if (marks >= 55) 
            {
                grade = "C";
            }
            else if (marks >= 40) 
            {
                grade = "D";
            }
            else 
            {
                grade = "F";
            }

            Console.WriteLine($"\nResult: Marks of {marks} corresponds to Grade: {grade}");
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a whole number between 0 and 100.");
        }
        Console.WriteLine("---------------------------------------\n");
    }
}

public class Program
{
    
    public static void Main(string[] args)
    {
        
        GradeEvaluator evaluator = new GradeEvaluator();
        evaluator.DetermineGrade();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

