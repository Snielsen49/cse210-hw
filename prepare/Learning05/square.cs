public class Square : Shape
{
    private double _side;
    public Square( string color, double side) : base (color)
    {
        SetColor(color);
        _side = side;
    }
    public override double GetArea()
    {
        double area;
        area = _side * _side;
        return area;
    }
    
}