class Person
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }

    }
}
class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = Console.ReadLine();
        Console.WriteLine(person.Name);
    }
}