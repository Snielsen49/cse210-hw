using System;

class Program
{
    
    static void Main(string[] args)
    {
        Square test1 = new Square("Blue",5);
        // Console.WriteLine(test1.GetColor());
        // Console.WriteLine(test1.GetArea());

        Rectangle test2 = new Rectangle("Red",5,8);
        // Console.WriteLine(test2.GetColor());
        // Console.WriteLine(test2.GetArea());

        Circle test3 = new Circle("Green",50);
        // Console.WriteLine(test3.GetColor());
        // Console.WriteLine(test3.GetArea());

        List<Shape> _shapes = new List<Shape>();

        _shapes.Add(test1);
        _shapes.Add(test2);
        _shapes.Add(test3);

        foreach(Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }










    }
}