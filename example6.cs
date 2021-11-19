double g, pi, x, y, s, a, p, d, ch, zn;
int n, k;
m1: Console.WriteLine(" Enter angle value");
g = double.Parse(Console.ReadLine());
pi = Math.PI;
x = g * pi / 180;
Console.WriteLine("\t  Interval values \n");
k = 0; s = 0; p = 1; n = 3; d = 1; a = x;
while (Math.Abs(a) >= 0.000001)
{
	s += a;
	ch = x * x * x * d;
	p = -p * (n - 1) * 1;
	zn = p;
	a = ch / zn;
	d = x * x;
	n += 2;
	k++;
	Console.WriteLine('\t'  + "Iteration №" + k +  '\n' +  " a=" + a + " s=" + s + '\n');
}
y = Math.Sin(x);
Console.WriteLine('\t' + "Results:" + '\n' +  "Angle value in degrees =" + g + '\n' + "Sum =" + s + '\n' + "Number of values -" + k + '\n' + "Function SIN(x) =" + y + '\n');
Console.WriteLine("To repeat press any key \n To end the program press 'Enter' ");
string rep = Console.ReadLine();
if (rep != "") goto m1;
