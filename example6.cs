interface IShape
{
    void draw();
    void erase();
}
class Circle : IShape
{
    public void draw()
    {
        Console.WriteLine(" Circle.draw() ");
    }
    public void erase()
    {
        Console.WriteLine(" Circle.erase() ");
    }
}
class Square : IShape
{
    public void draw()
    {

        Console.WriteLine(" Square.draw() ");
    }
    public void erase()
    {
        Console.WriteLine(" Square.erase() ");
    }
}
class Triangle : IShape
{
    public void draw()
    {
        Console.WriteLine(" Triangle.draw() ");
    }
    public void erase()
    {
        Console.WriteLine(" Triangle.erase() ");
    }
}
public class ShapeManager
{
    public static void Main()
    {
        IShape s;
        s = new Circle();
        s.draw();
        s.erase();
        s = new Square();
        s.draw();
        s.erase();
        s = new Triangle();
        s.draw();
        s.erase();
    }
}