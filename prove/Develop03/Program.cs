using System;

// Bonus requirment: only using words that are not currently hidden when deciding more to hide.
// Also, please note, my terminal did not support using Console.Clear(). I have included where it would be
// placed, but have left it commented out.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");

        bool quit = false;
        while (quit == false) {
            // Console.Clear();

            Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDislayText()}.");
            Console.WriteLine("");
            
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (scripture.IsCompletelyHidden() == true) {
                quit = true;
            } else if (input == "quit") {
                quit = true;
            } else {
                scripture.HideRandomWords();
            }
        }
    }
}