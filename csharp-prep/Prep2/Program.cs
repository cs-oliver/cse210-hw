using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

    string letter = "";

    if (percentage >= 90)
        {
            letter = "A";      
        }
    else if (percentage  >= 80)
        {
            letter = "B";
        }
    else if (percentage >= 70)
        {
            letter = "C";
        }
    else if (percentage >= 60)
        {
            letter = "D";
        }
    else
        {
            letter = "F";
        } 

        Console.WriteLine($"Your grade is {letter}.");

        if (percentage >= 70)
            {
                Console.WriteLine($"Congratulations, you passed!");
            }
        else 
            {
                Console.WriteLine($"You need to retake the course. Better luck next time.");
            }
    }
}
