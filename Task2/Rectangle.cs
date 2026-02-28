namespace ClassDemo;

public class Rectangle : Shape
{
    public double _side1{get; set;}
    public double _side2{get; set;}

    public Rectangle(Location c, double side1, double side2) : base(c)
    {
        _side1 = side1;
        _side2 = side2;
    }

    public override double Area()
    {
        return _side1 * _side2;
    }

    public override double Perimeter()
    {
        return 2 * (_side1 + _side2);
    }
    public override string ToString()
    {
        return $"This is Rectangle";
    }
}