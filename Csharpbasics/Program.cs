using LearnCollections;

public class Program
{
    static void Main()
    {
        var square = new Square(33.45);
        square.Display();

        var rectangle = new Rectangle(33.45, 50.2);
        var rectangleArea = rectangle.GetArea();

    }
}