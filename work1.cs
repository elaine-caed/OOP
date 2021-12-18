class Magazine : PrintEdition
{
    public int adnumber = 16; // кількість реклами в журналі
    private int articlenumber = 6;
    public void Content() // зміст
    {
        int count = 0;
        for (int i = 0; i < articlenumber; i++)
        {
            count++;
            Console.Write($"Article {count}; ");
        }
        Console.WriteLine();
    }
    private static int count = 0;
    public Magazine(string title, string author, int year, int pages)
        :base(title, author, year, pages)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pages = pages;
        count++;
    }
    public static void DisplayCounter()
    {
        Console.WriteLine($"{count} magazines");
    }
}
class Bookmark
{
    int pages;
    public void BM(int pages)
    {
        Console.Write("Enter on which page you finished: ");
        int a = int.Parse(Console.ReadLine());
        if (a <= pages)
        {
            Console.WriteLine($"Bookmark is on page {a}");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    public Bookmark(int pages)
    {
        this.pages = pages;
    }
}
class Book : PrintEdition
{
    Bookmark bookmark;
    private static int count = 0;
    public Book(string title, string author, int year, int pages)
        : base(title, author, year, pages)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pages = pages;
        count++;
        bookmark = new Bookmark(pages);
    }
    public void B()
    {
        bookmark.BM(pages);
    }
    public static void DisplayCounter1()
    {
        Console.WriteLine($"{count} books");
    }
}
class PrintEdition
{
    public string title;
    public string author;
    public int year;
    public int pages;
    public PrintEdition(string title, string author, int year, int pages)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pages = pages;
    }
    public void Info() // вивід інформації щодо друкованого видання
    {
        Console.WriteLine($"Title: '{title}'; Author: '{author}'; Year of publishment: {year}; Number of pages:{pages}");
    }
}
class Textbook : Book
{
    private int exercisenumber;// кількість завдань на кожній сторінці якщо вважати що на кожній сторінці їх рівна кількість
    public int Exercisenumber
    {
        set
        {
            exercisenumber = value;
        }
        get { return exercisenumber; }
    }
    private int x;
    public void ExTotal(int y) //цей метод знаходить загальну кількість завдань в підручнику
    {
        x = Exercisenumber * y;
        Console.WriteLine($"Total amount of exercises: {x}");
    }
    private static int count = 0;
    public Textbook(string title, string author, int year, int pages)
        : base(title, author, year, pages)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pages = pages;
        count++;
    }
    public static void DisplayCounter2()
    {
        Console.WriteLine($"{count} textbooks");
    }
}
class Program
{
    static void Main()
    {
      PrintEdition book0 = new PrintEdition("A", "B", 3, 4);
        Magazine M = new Magazine("Vogue", "Anna Wintour", 2021, 158);
        M.Info();
        M.Content();
        Console.WriteLine($"Number of ads: {M.adnumber}");
        Book book00 = new Book("Black Cat", "Edgar Allan Poe", 1843, 368);
        book00.Info();
        book00.B();
        Textbook text = new Textbook("English coursebook", "Rachael Harding", 2016, 168);
        text.Info();
        Console.Write("Enter number of the excersices: ");
        text.Exercisenumber = int.Parse(Console.ReadLine());
        text.ExTotal(text.pages);
        Console.WriteLine("We have:");
        Magazine M1 = new Magazine("Vogue", "Anna Wintour", 2021, 158);
        Magazine.DisplayCounter();
        Book book = new Book("Black Cat", "Edgar Allan Poe", 1843, 368);
        Book.DisplayCounter1();
        Textbook book2 = new Textbook("English coursebook", "Rachael Harding", 2016, 168);
        Textbook.DisplayCounter2();
    }
}