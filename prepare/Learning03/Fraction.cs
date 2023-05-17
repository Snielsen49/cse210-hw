public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNum)
    {
        _top = wholeNum;
        _bottom = 1;
    }
    public Fraction(int topNum, int bottomNum)
    {
        _bottom = bottomNum;
        _top = topNum;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string stringFraction = $"{_top}/{_bottom}";
        return stringFraction;
    }
    public double GetDecimalValue()
    {
        double num = (double)_top/(double)_bottom;
        return num;
    }
}