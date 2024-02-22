public abstract class Expense {
    protected double _amount;
    protected string _name;

    public Expense(double a, string n) {
        _amount = a;
        _name = n;
    }

    public double GetAmount() {
        return _amount;
    }

    public string GetStringRepresentation() {
        return $"{_name}: {_amount}";
    }
}