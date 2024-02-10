using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running == true) {
            goalManager.DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input) {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Thank you and goodbye");
                    Console.WriteLine("Closing the program");
                    break;
                default:
                    Console.WriteLine("Invalid menu entry, please try again");
                    break;
            }
        }
    }
}