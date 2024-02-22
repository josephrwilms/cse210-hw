public class RecurringExpense : Expense {
    private int _length;
    public RecurringExpense(double amount, string name, int length) : base (amount, name) {
        _length = length;
    }
}