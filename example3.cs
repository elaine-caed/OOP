int a, b, s, k;
Console.WriteLine("Enter a - left edge");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b - left edge");
b = int.Parse(Console.ReadLine());
s = 0;
k = 0;
while (a <= b)
{
	s += a;
	k++;
	a++;
}
Console.WriteLine('\t' + "Result:" + " s= " + s + " k=" + k + '\n');
