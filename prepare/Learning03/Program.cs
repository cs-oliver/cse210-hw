using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction(1);
        Console.WriteLine($"{frac1.GetFractionString()} = {frac1.GetDecimalValue()}"); 

        Fraction frac2 = new Fraction(7);
        Console.WriteLine($"{frac2.GetFractionString()} = {frac2.GetDecimalValue()}"); 
        
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine($"{frac3.GetFractionString()} = {frac3.GetDecimalValue()}");   

        Fraction frac4 = new Fraction(2,  3);
        Console.WriteLine($"{frac4.GetFractionString()} = {frac4.GetDecimalValue()}");

        Fraction frac5 = new Fraction(17,  4);
        Console.WriteLine($"{frac5.GetFractionString()} = {frac5.GetDecimalValue()}");
    }
}