class Shape
{
    public virtual void draw()
    {
        Console.WriteLine(" Shape.draw() ");
    }
    public virtual void erase()
    {
        Console.WriteLine(" Shape.erase() ");
    }
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
        Shape s = new Shape();
        s.draw();
        s.erase();
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