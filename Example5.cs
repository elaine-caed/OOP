StreamWriter p = new StreamWriter("rez.txt");
float a, x;
double y;
p.WriteLine(" CALCULATION RESULTS");
for (a = 1; a <= 2; a += 0.5f)
{
	p.WriteLine(" a=" + a);
	for (x = 1; x <= 7; x += 0.25f)
	{
		y = Convert.ToDouble(a * Math.Cos(x)) / Math.Sqrt(1 + a * Math.Pow(x, 2));
		p.WriteLine(" x=" + x + '\t' + " y=" + y);
	}
}
p.Close();
