public class Asset {
    private double _amount;

    private string _name;

    public Asset(double a, string n) {
        _amount = a;
        _name = n;
    }

    public string GetRepresentation() {
        return $"{_name}: {_amount}";
    }
}