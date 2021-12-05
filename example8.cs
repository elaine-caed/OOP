class Algorithm
{
    public static double pi = 3.14;
    public static int Factorial(int x)
    {
        if (x == 1)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
    public static int Fibonachi(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        if (x == 1)

        {
            return 1;
        }
        else
        {
            return Fibonachi(x - 1) + Fibonachi(x - 2);
        }
    }
}
class Program
{
    static void Main()
    {
        int num1 = Algorithm.Factorial(5);
        int num2 = Algorithm.Fibonachi(5);
        Algorithm.pi = 3.14159;
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}