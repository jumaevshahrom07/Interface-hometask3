using ClassDemo;

Location location1 = new Location(3, 2);
Rectangle rectangle = new Rectangle(location1, 5, 6);

Location location2 = new Location(2, 3);
Circle circle = new Circle(location2, 5);

Console.WriteLine("Rectangle Area : " + rectangle.Area());
Console.WriteLine("Rectangle Perimeter : " + rectangle.Perimeter());


Console.WriteLine("Cicrle Area :" + circle.Area());
Console.WriteLine("Cicrle Perimeter :" + circle.Perimeter());

Location location3 = new Location(5, 5);
Shape shape = new Shape(location3);

System.Console.WriteLine(shape.ToString());
System.Console.WriteLine(rectangle.ToString());
System.Console.WriteLine(circle.ToString());