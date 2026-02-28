namespace ClassDemo;

public class Shape
{
    public Location _c;

    public Shape(Location c)
    {
        _c = c;
    }

    public virtual double Area()
    {
        return 0;
    }

    public virtual double Perimeter()
    {
        return 0;
    }
}