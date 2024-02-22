public class Manager {
    List<User> _users = new List<User>();
    User _selectedUser;

    public void DisplayUsersInfo() {
       int index = 1;
        foreach (User user in _users) {
            Console.WriteLine($" {index}. {user.DisplayInfo()}");
            index++;
        }
    }

    public Manager() {
        // Add some users by default
        User user1 = new User("Joseph");
        User user2 = new User("Deneile");

        user1.AddAsset(100.00, "Asset 1");
        user1.AddAsset(150.00, "Asset 2");

        user1.AddIncome(900.00, "Tax Refund");
        user1.AddIncome(500.00, "Paycheck", 60);

        user1.AddExpense(350.00, "Car Repairs");
        user1.AddExpense(300.00, "Rent", 60);

        _users.Add(user1);
        _users.Add(user2);

        // Set default user to user 1, so a user is always selected
        _selectedUser = user1;
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
            Console.WriteLine("  7. Show Account Details");
            Console.WriteLine("  8. When can I afford this?");
            Console.WriteLine("  9. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input) {
                case "1":
                    DisplayUsersInfo();
                    break;
                case "2":
                    DisplayUsersInfo();
                    Console.Write("Select a choice from the list: ");
                    _selectedUser = _users[int.Parse(Console.ReadLine())-1];
                    Console.WriteLine($"Selected {_selectedUser.GetName()}");
                    break;
                case "3":
                    Console.WriteLine($"{_selectedUser.GetName()}'s current balance is ${_selectedUser.GetCurrentAmount()}");
                    break;
                case "4":
                    Console.Write("Enter the amount for the income: ");
                    double amountIncome = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the description for the income: ");
                    string descriptionIncome = Console.ReadLine();
                    Console.Write("Is this income recurring? (yes/no): ");
                    bool isRecurringIncome = Console.ReadLine().ToLower() == "yes";
                    int lengthMonthsIncome = 0;
                    if (isRecurringIncome) {
                        Console.Write("Enter the length of recurrence in months: ");
                        lengthMonthsIncome = Convert.ToInt32(Console.ReadLine());
                        _selectedUser.AddIncome(amountIncome, descriptionIncome, lengthMonthsIncome);
                    } else {
                         _selectedUser.AddIncome(amountIncome, descriptionIncome);
                    }
                    break;
                case "5":
                    Console.Write("Enter the amount for the expense: ");
                    double amountExpense = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the description for the expense: ");
                    string descriptionExpense = Console.ReadLine();
                    Console.Write("Is this expense recurring? (yes/no): ");
                    bool isRecurringExpense = Console.ReadLine().ToLower() == "yes";
                    int lengthMonthsExpense = 0;
                    if (isRecurringExpense) {
                        Console.Write("Enter the length of recurrence in months: ");
                        lengthMonthsExpense = Convert.ToInt32(Console.ReadLine());
                        _selectedUser.AddExpense(amountExpense, descriptionExpense, lengthMonthsExpense);
                    } else {
                        _selectedUser.AddExpense(amountExpense, descriptionExpense);
                    }
                    break;
                case "6":
                    Console.Write("Enter the amount for the asset: ");
                    double amountAsset = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the description for the asset: ");
                    string descriptionAsset = Console.ReadLine();
                    _selectedUser.AddAsset(amountAsset, descriptionAsset);
                    break;
                case "7":
                    _selectedUser.ListDetails();
                    break;
                case "8":
                    Console.Write("Enter the cost of the item: ");
                    double itemCost = Convert.ToDouble(Console.ReadLine());
                    double totalMonthlyIncome = _selectedUser.GetTotalMonthlyIncome();
                    double totalMonthlyExpense = _selectedUser.GetTotalMonthlyExpense();
                    double netIncomePerMonth = totalMonthlyIncome - totalMonthlyExpense;
                    double netWorth = _selectedUser.GetTotalAssets() + netIncomePerMonth;
                    double shortfall = itemCost - netWorth;
                    if (shortfall <= 0) {
                        Console.WriteLine("Congratulations! You can afford this item right now.");
                    } else {
                        Console.WriteLine($"You currently do not have enough money to afford this item. You need an additional ${shortfall}.");
                        if (netIncomePerMonth <= 0) {
                            Console.WriteLine("Your monthly income is not sufficient to cover your expenses. Please increase your income or decrease your expenses.");
                        } else {
                            double monthsToAfford = shortfall / netIncomePerMonth;
                            Console.WriteLine($"Based on your current financial situation, it will take approximately {Math.Ceiling(monthsToAfford)} months to afford this item.");
                        }
                    }
                    break;
                case "9":
                    running = false;
                    Console.WriteLine("Thank you and goodbye");
                    Console.WriteLine("Closing the program");
                    break;
                default:
                    Console.WriteLine("Invalid menu entry, please try again");
                    break;
            }
            Console.WriteLine("");
        }
    }
}