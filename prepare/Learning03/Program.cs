using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction newFraction = new Fraction();
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());

        Fraction newFraction2 = new Fraction(5);
        Console.WriteLine(newFraction2.GetFractionString());
        Console.WriteLine(newFraction2.GetDecimalValue());

        Fraction newFraction3 = new Fraction(3,4);
        Console.WriteLine(newFraction3.GetFractionString());
        Console.WriteLine(newFraction3.GetDecimalValue());
        Console.WriteLine(newFraction3.GetTop());
        Console.WriteLine(newFraction3.GetBottom());
        newFraction3.SetTop(1);
        newFraction3.SetBottom(3);
        Console.WriteLine(newFraction3.GetFractionString());

    }
}