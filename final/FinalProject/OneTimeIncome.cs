public class OneTimeIncome : Income {
    public OneTimeIncome(double amount) : base (amount) {
    }

    public override string GetStringRepresentation() {
        return "test";
    }
}