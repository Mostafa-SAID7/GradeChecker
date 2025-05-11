//Summary: Grade Checker Console App in C#

//This C# console application prompts the user to enter their marks,
//then determines and displays the corresponding letter grade based on the following grading scale:

//90 and above: Grade A
//80 to 89: Grade B
//70 to 79: Grade C
//60 to 69: Grade D
//Below 60: Grade F

//The application uses int.TryParse() to safely convert the user's input into an integer.
//If the input is not a valid number, the program will display an error message instead of crashing.

//This simple program demonstrates:
//User input handling via Console.ReadLine()
//Safe conversion using int.TryParse()
//Conditional logic with if-else if-else statements
//Basic grading logic common in academic settings
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your marks: ");
        string input = Console.ReadLine();

        try
        {
            int marks = Convert.ToInt32(input);

            if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }
        catch
        {
            Console.WriteLine("Invalid input. Please enter numeric marks.");
        }
    }
}
