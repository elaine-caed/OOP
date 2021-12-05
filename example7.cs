class Account
{
    private int sum;
    public int Sum
    {
        get { return sum; }
        set
        {
            if (value > 0)
            {
                sum = value;
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Account account = new Account();
        account.Sum = int.Parse(Console.ReadLine());
        Console.WriteLine(account.Sum);
    }
}