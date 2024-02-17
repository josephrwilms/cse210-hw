public abstract class Income {
    protected double _amount;

    public Income(double amount) {
        _amount = amount;
    }

    public abstract string GetStringRepresentation();
}