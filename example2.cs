class Book
{
    public string name;
    public string author;
    public int year;
    public Book()
    { }
    public Book(string name, string author, int year)
    {
        this.name = name;
        this.author = author;
        this.year = year;
    }
    public void Info()
    {
        Console.WriteLine(" Книга '{0}' (автор {1}) была издана в {2} году ", name, author, year);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        book.name = Console.ReadLine();
        book.author = Console.ReadLine();
        book.year = int.Parse(Console.ReadLine());
        book.Info();
    }
}