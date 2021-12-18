class Hero { }
class Animal : Hero
{
    public void Hunt() { }
}
class Human : Hero
{
    public void ReadBook() { }
}
class Woman : Human
{
    public void MakeCake() { }

}
class Man : Human
{
    public void CutTrees() { }
}
class Art
{
    public Art() { Console.WriteLine(" Art "); }
}
class Drawing : Art
{
    public Drawing() { Console.WriteLine(" Drawing "); }
}
class Cartoon : Drawing
{
    public Cartoon() { Console.WriteLine(" Cartoon "); }
    public static void Main(String[] args)
    {
        Cartoon x = new Cartoon();
    }
}