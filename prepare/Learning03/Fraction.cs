using System;
using System.Diagnostics;

public class Fraction
{
    private int _top; // attribute encapsulated
    private int _bottom; // attribute encapsulated

    public Fraction() // constructor
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber) // method
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom) // method
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}