public abstract class Income {
    protected double _amount;
    protected string _name;

    public Income(double amount, string name) {
        _amount = amount;
        _name = name;
    }

    public double GetAmount() {
        return _amount;
    }

    public string GetStringRepresentation() {
        return $"{_name}: {_amount}";
    }
}