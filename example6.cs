class Person
{
    private int age;
    public int Age
    {
        set
        {
            if (value > 18)
{
                Console.WriteLine(" Возраст должен быть небольше 18 ");
            }
            else
            {
                age = value;
            }
        }
        get 
        { 
            return age; 
        }
    }
}
class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Age = int.Parse(Console.ReadLine());
        Console.WriteLine(person.Age);
    }
}