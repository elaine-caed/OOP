double y, x, a, pi = Math.PI;
Console.WriteLine(" CALCULATION RESULTS");
for (a = 0; a <= 2; a += 0.5f)
{
	Console.WriteLine(" a= {0}", a);
	for (x = 0; x <= pi; x += (pi/36))
	{
		y = Math.Exp(-x * a) * Math.Sin(x);
		Console.WriteLine(" x= {0} \t  y= {1}", x, y);
	}
}
