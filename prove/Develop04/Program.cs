using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running == true) {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu");
            string input = Console.ReadLine();
            switch (input) {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivty listingActivty = new ListingActivty();
                    listingActivty.Run();
                    break;
                case "4":
                Console.WriteLine("Thank you and goodbye!");
                    running = false;
                    break;
                default:

                    break;
            }   
        }
    }
}