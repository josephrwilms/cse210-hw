using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade (percentage)? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        Console.WriteLine("");

        string letterGrade;
        bool passing;

        if (grade >= 90) 
        {
            letterGrade = "A";
            passing = true;
        }

        else if (grade >= 80) 
        {
            letterGrade = "B";
            passing = true;
        }

        else if (grade >= 70) 
        {
            letterGrade = "C";
            passing = true;
        }

        else if (grade >= 60) 
        {
            letterGrade = "D";
            passing = false;
        }

        else 
        {
            letterGrade = "F";
            passing = false;
        }

        Console.WriteLine($"{grade}% is a {letterGrade}");

        if (passing) {
            Console.WriteLine($"You are currently passing");
        }

        else {
            Console.WriteLine($"You are currently not passing");
        }
        
    }
}