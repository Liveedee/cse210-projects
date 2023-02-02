using System;


public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;

    }

    public Fraction(int topDenominator,int bottomDenominator)
    {
        _top = topDenominator;
        _bottom = bottomDenominator;
    }

    public string NewFraction()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    public float NewDecimal()
    {
        return(float)_top / (float) _bottom;
    }


}
