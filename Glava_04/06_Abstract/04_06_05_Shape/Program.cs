var rectangle = new Rectangle { Width =20, Height =20 };
var circle = new Circle { Radius = 200 };
PrintShape(rectangle);
PrintShape(circle);

void PrintShape(Shape shape)
{
    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}, Area: {shape.GetArea()}");
}

abstract class Shape
{
    public abstract double GetPerimeter();
    public abstract double GetArea();
}

class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }
    public override double GetPerimeter() => Width * 2 + Height * 2;
    public override double GetArea() => Width * Height;
}

class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetPerimeter() => Radius * 2 * 3.14;
    public override double GetArea() => Radius * Radius * 3.14;
}