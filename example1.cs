using System;
namespace ConsoleApplication1
{
    class Program
    {
        class vect
        {
            double[] a;
            int n;
            public vect(int n)
            {
                this.a = new double[n];
                this.n = n;
            }
            public int vv()
            {
                for (int i = 0; i < n; i++)
                {
                    string buf;
                    buf = Console.ReadLine();
                    a[i] = Convert.ToDouble(buf);
                }
                return (0);
            }
            public int vyv()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("a[" + i + "]= " + a[i]);
                }
                return (0);
            }
            public int perest (int k)
            {
                int kl = 0;
                    if (k >= n) kl = -1;
                    else
                    {
                        int cnt = 0;
                        int pos = -1;
                        double tmp;
                        while ( cnt < k)
                        {
                            pos++;
                            if (a[pos] < 0)
                            {
                                cnt++;
                            }
                        }
                        tmp = a[pos];
                        a[pos] = a[0];
                        a[0] = tmp;
                        kl = 0;
                    }
                return kl;
            }
            static void Main()
            {
                vect d = new vect(5);
                d.vv();
                d.vyv();
                d.perest(2);
                d.vyv();
            }
        }
    }
}
