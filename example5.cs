abstract class Shape
{
    public abstract void draw();
    public abstract void erase();
}
class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine(" Circle.draw() ");
    }
    public override void erase()
    {
        Console.WriteLine(" Circle.erase() ");
    }
}
class Square : Shape
{
    public override void draw()
    {
        Console.WriteLine(" Square.draw() ");
    }
    public override void erase()
    {
        Console.WriteLine(" Square.erase() ");
    }
}
class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine(" Triangle.draw() ");
    }
    public override void erase()
    {
        Console.WriteLine(" Triangle.erase() ");
    }
}
public class ShapeManager
{
    public static void Main()
    {
        Shape s;
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
