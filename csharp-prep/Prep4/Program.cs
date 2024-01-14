using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        bool finished = false;

        List<int> numbers = new List<int>();

        while (finished == false) {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0) {
                finished = true;
            }
            else {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0) {
            int sum = 0;
            int largest = 0;
            float average = 0;

            foreach (int number in numbers) {
                sum += number;
                if (number > largest) {
                    largest = number;
                }
            }

            average = sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest numbers is: {largest}");
        }
        else {

        }
    }
}