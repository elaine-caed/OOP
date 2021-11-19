//StreamWriter p = new StreamWriter("rez.txt");
float a, x;
double y;
Console.WriteLine(" CALCULATION RESULTS");
for (a = 1; a <= 2; a += 0.5f)
{
	Console.WriteLine(" a={0}", a);
	for (x = 1; x <= 7; x += 0.25f)
	{
		y = Convert.ToDouble(a * x) / Math.Sqrt(1 + a * Math.Pow(x, 2));
		Console.WriteLine("  x={0}  \t   y={1}", x, y);
	}
}
//p.Close();
