using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square a = new Square("Orange", 5);
        shapes.Add(a);
        Rectangle b = new Rectangle("Yellow", 5, 5);
        shapes.Add(b);
        Circle c = new Circle("Red", 5);
        shapes.Add(c);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}