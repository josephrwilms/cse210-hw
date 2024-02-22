public class User {
    private string _name;
    private List<Income> _incomes = new List<Income>();

    private List<Expense> _expenses = new List<Expense>();

    private List<Asset> _assets = new List<Asset>();

    public User(string name) {
        _name = name;
    }

    public void AddAsset(double amount, string name) {
        Asset asset = new Asset(amount, name);
        _assets.Add(asset);
    }

    public void RemoveAsset(Asset asset) {
        _assets.Remove(asset);
    }

    public void AddIncome(double amount, string name) {
        OneTimeIncome income = new OneTimeIncome(amount, name);
        _incomes.Add(income);
    }

    public void AddIncome(double amount, string name, int length) {
        RecurringIncome income = new RecurringIncome(amount, name, length);
        _incomes.Add(income);
    }

    public void RemoveIncome(Income i) {
        _incomes.Remove(i);
    }

    public void AddExpense(double amount, string name) {
        OneTimeExpense expense = new OneTimeExpense(amount, name);
        _expenses.Add(expense);
    }

    public void AddExpense(double amount, string name, int length) {
        RecurringExpense expense = new RecurringExpense(amount, name, length);
        _expenses.Add(expense);
    }

    public string DisplayInfo() {
        return $"Name: {_name}";
    }

    public string GetName() {
        return $"{_name}";
    }

    public void ListDetails() {
        Console.WriteLine("Assets: ");
        foreach(Asset asset in _assets) {
            Console.WriteLine($"{asset.GetRepresentation()}");
        }
        Console.WriteLine("");

        Console.WriteLine("Incomes: ");
        foreach(Income income in _incomes) {
            Console.WriteLine($"{income.GetStringRepresentation()}");
        }
        Console.WriteLine("");

        Console.WriteLine("Expenses: ");
        foreach(Expense expense in _expenses) {
            Console.WriteLine($"{expense.GetStringRepresentation()}");
        }
    }

    public double GetCurrentAmount() {
        double amount = 0.00;

        foreach(Asset asset in _assets) {
            amount += asset.GetAmount();
        }

        foreach(Income income in _incomes) {
            amount += income.GetAmount();
        }

        foreach(Expense expense in _expenses) {
            amount -= expense.GetAmount();
        }

        return amount;
    }

    public double GetTotalMonthlyIncome() {
        double totalMonthlyIncome = 0.0;
        foreach (Income income in _incomes) {
            // For recurring incomes, add their monthly amount
            if (income is RecurringIncome recurringIncome) {
                totalMonthlyIncome += recurringIncome.GetAmount();
            } 
            // For one-time incomes, add their total amount (treated as one month's income)
            else if (income is OneTimeIncome oneTimeIncome) {
                totalMonthlyIncome += oneTimeIncome.GetAmount();
            }
        }
        return totalMonthlyIncome;
    }


    public double GetTotalMonthlyExpense() {
        double totalMonthlyExpense = 0.0;
        foreach (Expense expense in _expenses) {
            // For recurring expenses, add their monthly amount
            if (expense is RecurringExpense recurringExpense) {
                totalMonthlyExpense += recurringExpense.GetAmount();
            } 
            // For one-time expenses, add their total amount (treated as one month's expense)
            else if (expense is OneTimeExpense oneTimeExpense) {
                totalMonthlyExpense += oneTimeExpense.GetAmount();
            }
        }
        return totalMonthlyExpense;
    }

    public double GetTotalAssets() {
        double totalAssets = 0.0;
        foreach (Asset asset in _assets) {
            totalAssets += asset.GetAmount();
        }
        return totalAssets;
    }
}