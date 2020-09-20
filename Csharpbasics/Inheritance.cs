using System;

public interface IShapeWithSides
{
    public double GetDiagonal();
}

public abstract class Shape
{
    //define abstract members when you want to force derived classes to implement their own logic
    public abstract double GetArea();

    public abstract double GetCircumference();

    public virtual void Display()
    {
        Console.WriteLine($"Displaying result for some shape.");
    }

}


public class Square : Shape, IShapeWithSides 
{
    public Square(double side)
    {
        Side = side;
    }

    public double Side { get; set;}
    public override double GetArea() => Side * Side;
    public override double GetCircumference() => 4 * Side;

    public override void Display()
    {
        Console.WriteLine($"Displaying results for Square with side {Side}: \n");
        Console.WriteLine($"Area : {this.GetArea()} square unit \n");   
        Console.WriteLine($"Circumference : {this.GetCircumference()} unit \n");
    }

    public double GetDiagonal() => Math.Sqrt(2 * Side * Side);
}

public class Rectangle : Shape, IShapeWithSides //this is how we inherit, using colon
{

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public double Length { get; set;}
    public double Breadth { get; set;}

    public override double GetArea() => Length * Length;
    public override double GetCircumference() => 2 * (Length + Breadth);

    public double GetDiagonal() => Math.Sqrt(Length * Length + Breadth * Breadth);

}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2 * Math.PI * Radius;
}

class A
{ }

class B : A
{ }

class C : B
{ }

class D : IA, IB
{ }

interface IA
{ }
interface IB
{ }
