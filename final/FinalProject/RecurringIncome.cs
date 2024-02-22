public class RecurringIncome : Income {
    private int _length;
    public RecurringIncome(double amount, string name, int length) : base (amount, name) {
        _length = length;
    }
}