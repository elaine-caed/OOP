class State
{
    private static int counter = 0;
    public State()
    {
        counter++;
    }
    public static void DisplayCounter()
    {
        Console.WriteLine("Создано {0} объектов State",counter);
    }
}
class Program
{
    static void Main(string[] args)
    {
        State state1 = new State();
        State state2 = new State();
        State state3 = new State();
        State state4 = new State();
        State state5 = new State();
        State.DisplayCounter(); // 5
        Console.Read();
    }
}