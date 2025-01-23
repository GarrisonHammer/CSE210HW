using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        //sets the presets
        _top =  1;
        _bottom =1;
        
    }

    public Fraction(int wholeNumber)
    {

        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    public string GetFractionString()
    {
        //the getter for the fraction string
        //returns the string of top/bottom
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        //local variable which will be recomputed every time it is called
        //returns the decimal value of the calculation
        return (double)_top / (double)_bottom;
    }

}