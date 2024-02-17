public class OneTimeExpense : Expense {
    public OneTimeExpense(double amount) : base (amount) {
    }

    public override string GetStringRepresentation() {
        return "test";
    }
}