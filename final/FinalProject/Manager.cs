public class Manager {
    List<User> _users = new List<User>();
    User _selectedUser;

    public void DisplayUsersInfo() {
       Console.WriteLine("Puts User info"); 
    }

    public void Run() {
        bool running = true;

        while (running == true) {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. List Users");
            Console.WriteLine("  2. Select a User");
            Console.WriteLine("  3. View Balance");
            Console.WriteLine("  4. Add Income");
            Console.WriteLine("  5. Add Expense");
            Console.WriteLine("  6. Add Asset");
            Console.WriteLine("  7. How long can I afford (tool)");
            Console.WriteLine("  8. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input) {
                case "1":
                    DisplayUsersInfo();
                    break;
                case "2":
                    Console.WriteLine("Select a user");
                    break;
                case "3":
                    Console.WriteLine("Show User balance");
                    break;
                case "4":
                    Console.WriteLine("Add income");
                    break;
                case "5":
                    Console.WriteLine("Add expense");
                    break;
                case "6":
                    Console.WriteLine("Add asset");
                    break;
                case "7":
                    Console.WriteLine("Affording tool");
                    break;
                case "8":
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