using System;
using System.IO;

// I added a "mood" along with every entry for the user to describe how they felt that day.
// Of course, it too can be saved, loaded and viewed.

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Journal journal = new Journal();
        PromptGenerator genreator = new PromptGenerator();

        Console.WriteLine("Welcome to the journal app!");

        while (running == true) {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("(1) - Add a new entry");
            Console.WriteLine("(2) - Display my journal");
            Console.WriteLine("(3) - Save my journal to file");
            Console.WriteLine("(4) - Load journal from file");
            Console.WriteLine("(5) - Exit the program");

            string userInput = Console.ReadLine();
            int menuOption = int.Parse(userInput);

            switch (menuOption) {
                case 1:
                    Entry entry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    entry._date = theCurrentTime.ToShortDateString();
                    entry._prompt = genreator.GetRandomPrompt();

                    Console.WriteLine("How did you feel today?");
                    entry._mood = Console.ReadLine();

                    Console.WriteLine($"Here is your prompt: {entry._prompt}");
                    entry._entry = Console.ReadLine();

                    journal.AddEntry(entry);
                    break;

                case 2:
                    Console.WriteLine("Displaying current journal entries:");
                    foreach (Entry e in journal._entires){
                        e.Display();
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("What filename would you like to use? (Please include .txt at the end)");
                    string saveFileName = Console.ReadLine();

                    Console.WriteLine("Saving....");

                    using (StreamWriter outputFile = new StreamWriter(saveFileName)) {
                        foreach (Entry e in journal._entires) {
                            outputFile.WriteLine($"{e._date}~~{e._prompt}~~{e._mood}~~{e._entry}");
                        }
                    }

                    Console.WriteLine("Saved!");

                    break;

                case 4:
                    Console.WriteLine("What filename would you like to use? (Please include .txt at the end)");
                    string readFileName = Console.ReadLine();

                    Console.WriteLine("Loading from file...");

                    string[] lines = System.IO.File.ReadAllLines(readFileName);

                    foreach (string line in lines) {
                        string[] parts = line.Split("~~");

                        Entry newEntry = new Entry();
                        newEntry._date = parts[0];
                        newEntry._prompt = parts[1];
                        newEntry._mood = parts[2];
                        newEntry._entry = parts[3];

                        journal.AddEntry(newEntry);
                    }

                    Console.WriteLine("Loaded journal successfully");

                    break;

                case 5:
                    running = false;
                    Console.WriteLine("Thanks and goodbye, exiting now.");
                    break;

                default:
                    Console.WriteLine("Sorry, not a valid entry. Please try again");
                    break;
            }


            
        }
    }
}