using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Red", 4);
        Console.WriteLine($"{square1.GetColor()}");
        Console.WriteLine($"{square1.GetArea()}");

        Rectangle rectangle1 = new Rectangle("Yellow", 12, 9);
        Console.WriteLine($"{rectangle1.GetColor()}");
        Console.WriteLine($"{rectangle1.GetArea()}");

        Circle circle1 = new Circle("Green", 7);
        Console.WriteLine($"{circle1.GetColor()}");
        Console.WriteLine($"{circle1.GetArea()}");

        List<Shape>shapes = new List<Shape>();
        shapes.Add(rectangle1);
        shapes.Add(square1);
        shapes.Add(circle1);

        foreach(Shape shape in shapes)
        {
           Console.WriteLine($"color: {shape.GetColor()}");
           Console.WriteLine($"Area: {shape.GetArea()}");  
            
        }
    }
}