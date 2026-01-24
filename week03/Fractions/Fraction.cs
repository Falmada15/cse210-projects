public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor 1: no parameters (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: top only (top/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor 3: top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns fraction as string (e.g. 3/4)
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value (e.g. 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
