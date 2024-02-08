using System;

public class Fraction
{
    public int numerator;
    public int denominator;

    public Fraction()
    {
        numerator =  1;
        denominator =  1;
    }

    public Fraction(int num)
    {
        numerator = num;
        denominator =  1;
    }

    public Fraction(int num, int denom)
    {
        numerator = num;
        denominator = denom;
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}