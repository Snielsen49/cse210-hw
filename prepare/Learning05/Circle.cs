public class  Circle: Shape
{
    private double _radius;
    public Circle( string color, double radius) : base (color)
    {
        SetColor(color);
        _radius=radius;
    }
    public override double GetArea()
    {
        double area;
        area =  _radius * _radius * double.Pi;
        return area;
    }
}