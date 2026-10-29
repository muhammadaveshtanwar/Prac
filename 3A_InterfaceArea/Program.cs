using System;

interface IArea
{
    double CalculateArea();
}

class Circle : IArea
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : IArea
{
    public double Length, Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle(5);
        Rectangle r = new Rectangle(10, 4);

        Console.WriteLine($"Circle Area: {c.CalculateArea()}");

        Console.WriteLine($"Rectangle Area: {r.CalculateArea()}");
    }
}