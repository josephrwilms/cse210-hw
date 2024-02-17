public class RecurringExpense : Expense {
    public RecurringExpense(double amount) : base (amount) {
    }

    public override string GetStringRepresentation() {
        return "test";
    }
}