using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        fraction1.GetDecimalValue();
        fraction1.GetFractionString();

        fraction2.GetDecimalValue();
        fraction2.GetFractionString();

        fraction3.GetDecimalValue();
        fraction3.GetFractionString();

        fraction4.GetDecimalValue();
        fraction4.GetFractionString();
    }
}