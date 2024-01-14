using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        bool guessed = false;

        while (guessed == false) {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);

            if (guess == number) {
                Console.WriteLine("You guessed it!");
                guessed = true;
            }

            else if (guess > number) {
                Console.WriteLine("Lower");
            }

            else {
                Console.WriteLine("Higher");
            }
        }
    }
}