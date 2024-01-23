public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop() {
        return _top;
    }

    public void SetTop(int wholeNumber) {
        _top = wholeNumber;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void SetBottom(int wholeNumber) {
        _bottom = wholeNumber;
    }

    public string GetFractionString() {
        string s = _top.ToString();
        if (_bottom != 1) {
            s += "/" + _bottom.ToString();
        }
        return s;
    }

    public double GetDecimalValue() {
        return _top / _bottom;
    }
}