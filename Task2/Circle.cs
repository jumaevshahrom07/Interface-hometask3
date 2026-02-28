namespace ClassDemo;

public class Circle : Shape
{
    private double _radius{get; set;}

    private double _PI {get; set;} = 3.14; 

    public Circle(Location c, double radius) : base(c)
    {
        _radius = radius;
    }

    public override double Area()
    {
        return _PI * _radius * _radius;
    }

    public override double Perimeter()
    {
        return 2 * _PI * _radius;
    }

    public override string ToString()
    {
        return $"This is Cicrle";
    }
}