class State
{
    static State()
    {
        Console.WriteLine("Создано первое государство ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        State s1 = new State(); // здесь сработает статический конструктор
        State s2 = new State();
        Console.ReadLine();
    }
}
