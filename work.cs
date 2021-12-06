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
    public Magazine()
    {
        count++;
    }
    public static void DisplayCounter()
    {
        Console.WriteLine($"{count} magazines");
    }
}
class Book : PrintEdition
{
    public void Bookmark(int x)
    {
        Console.Write("Enter on which page you finished: ");
        int a = int.Parse(Console.ReadLine());
        if (a <= x)
        {
            Console.WriteLine($"Bookmark is on page {a}");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    private static int count = 0;
    public Book()
    {
        count++;
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
    public void Info(string title, string author, int year, int pages) // вивід інформації щодо друкованого видання
    {
        Console.WriteLine($"Title: '{title}'; Author: '{author}'; Year of publishment: {year}; Number of pages:{pages}") ;
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
    public Textbook()
    {
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
        PrintEdition book0 = new PrintEdition();
        Magazine M = new Magazine();
        M.title = "Vogue";
        M.author = "Anna Wintour";
        M.year = 2021;
        M.pages = 158;
        M.Info(M.title, M.author, M.year, M.pages);
        M.Content();
        Console.WriteLine($"Number of ads: {M.adnumber}");
        Book book00 = new Book();
        book00.title = "Black Cat";
        book00.author = "Edgar Allan Poe";
        book00.year = 1843;
        book00.pages = 368;
        book00.Info(book00.title, book00.author, book00.year, book00.pages);
        book00.Bookmark(book00.pages);
        Textbook text = new Textbook();
        text.title = "English coursebook";
        text.author = "Rachael Harding";
        text.year = 2016;
        text.pages = 168;
        text.Info(text.title, text.author, text.year, text.pages);
        Console.Write("Enter number of the excersices: ");
        text.Exercisenumber = int.Parse(Console.ReadLine());
        text.ExTotal(text.pages);
        Console.WriteLine("We have:");
        Magazine M1 = new Magazine();
        Magazine.DisplayCounter();
        Book book = new Book();
        Book.DisplayCounter1();
        Textbook book2 = new Textbook();
        Textbook.DisplayCounter2();
    }  
}