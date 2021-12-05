public class State
{
    int a;
    private int b;
    protected int c;
    internal int d;
    protected internal int e;
    public int f;
    private void Display_f()
    {
        Console.WriteLine(" Переменная f = {0}", f);
    }
    public void Display_a()
    {
        Console.WriteLine(" Переменная a = {0}", a);
    }
    internal void Display_b()
    {
        Console.WriteLine("Переменная b = {0}", b);
    }
    protected void Display_e()
    {
        Console.WriteLine("Переменная e = {0}", e);
    }
}
class Program
{
    static void Main(string[] args)
    {
        State state1 = new State();
        state1.d = 5;
        state1.e = 8;
        state1.f = 8;
        state1.Display_a();
        state1.Display_b();
        Console.ReadLine();
    }
}