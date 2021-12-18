interface PrintEdition
{
    void Info();
    void Burn();
    void Warning();
}
class Book : PrintEdition
{
    public string title = "Black Cat";
    public string author = "Edgar Allan Poe";
    public int year = 1843;
    public int pages = 368;
    public void Info()
    {
    Console.WriteLine($"Title: '{title}'; Author: '{author}'; Year of publishment: {year}; Number of pages:{pages}");
    }
    public void Burn()
    {
        Console.WriteLine($"Book '{title}'; Author: '{author}' must be burnt");
    }
    public void Warning()
    {
        Console.WriteLine($"WARNING! Book '{title}'; Author: '{author}' is on fire");
    }
}
class Magazine : PrintEdition
{
    public string title = "Vogue";
    public string author = "Anna Wintour";
    public int year = 2021;
    public int pages = 158;
    public void Info()
    {
        Console.WriteLine($"Magazine: '{title}'; Editor: '{author}'; Year of publishment: {year}; Number of pages:{pages}");
    }
    public void Burn()
    {
        Console.WriteLine($"Magazine '{title}'; Editor: '{author}' must be burnt with style");
    }
    public void Warning()
    {
        Console.WriteLine($"Alarm! Magazine '{title}'; Editor: '{author}' is on fire, honey");
    }
}
class Textbook : PrintEdition
{
    public string title = "A";
    public string author = "B";
    public int year = 3;
    public int pages = 4;
    public void Info()
    {
        Console.WriteLine($"Textbook: '{title}'; Author: '{author}'; Year of publishment: {year}; Number of pages:{pages}");
    }
    public void Burn()
    {
        Console.WriteLine($"Textbook '{title}'; Author: '{author}' must not be burnt");
    }
    public void Warning()
    {
        Console.WriteLine($"Achtung! Textbook '{title}'; Author: '{author}' is burning");
    }
}
class Program
{
    static void Main()
    {
        PrintEdition a;
        a = new Book();
        a.Info();
        a.Burn();
        a.Warning();
        a = new Magazine();
        a.Info();
        a.Burn();
        a.Warning();
        a = new Textbook();
        a.Info();
        a.Burn();
        a.Warning();
    }
}