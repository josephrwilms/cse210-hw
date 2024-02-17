public abstract class Expense {
    protected double _amount;

    public Expense(double amount) {
        _amount = amount;
    }

    public abstract string GetStringRepresentation();
}