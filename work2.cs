double x, s, y, a, p, d, ch, zn;
int n, k;
Console.WriteLine(" Enter x:");
x = double.Parse(Console.ReadLine());
k = 0; s = 0; p = 1; n = 1; d = 1; a = x;
while (a <= 100)
{
	s += a;
	ch = Math.Pow(x, (2 * n - 1)) * d; ///x^(2n-1)*(2n-1)!
	p *= n;
	zn = 2 * p * (2 * p + p); ///2n!*(2n!+1)
	a = ch ;
	d *= (2 * n - 1);
	n += 1;
	k++;
	Console.WriteLine("\t Iteration #{0} \n a={1}  s={2} \n", k, a, s);
}
y = Math.Asin(x);
Console.WriteLine("\t y = {0} \n", y);
string rep = Console.ReadLine();


