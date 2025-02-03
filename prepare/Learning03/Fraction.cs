using System;
using System.Diagnostics;

public class Fraction
{
    private int _top; 
    private int _bottom; 

    public Fraction()  // to make a fraction of 1/1
    { 
        _top = 1; 
        _bottom = 1; 
    }

    public Fraction(int top) // have the user chose nominator
    { 
        _top = top; 
        _bottom = 1; 
    }

    public Fraction(int top, int bottom) // user choses nom and dom 
    { 
        _top = top; 
        _bottom = bottom; 
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }

} 

