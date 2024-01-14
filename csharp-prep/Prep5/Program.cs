using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }

    static int SquareNumber(int number) {
        return number * number;
    }

    static void DisplayResult(string name, int number) {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}