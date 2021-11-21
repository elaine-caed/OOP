namespace ConsoleApplication3
{
    class myprog
    {
        static void Main()
        {
            double[,] d = new double[3, 3];
            double[,] dt = new double[3, 3];
            double[,] ddt = new double[3, 3];
            int i; int j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    d[i, j] = Convert.ToDouble(Console.ReadLine());
            }
            transp(d, 3, dt);
            mt_q_mult(dt, d, ddt, 3);
        }
        static void transp(double[,] mtr, int p, double[,] mtrt)
        {
            int i; int j;
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < p; j++)
                    mtrt[j, i] = mtr[i, j];
            }
        }
        static void mt_q_mult(double[,] m_a, double[,] m_b, double[,] m_r, int p)
        {
            int i; int j; int k; double mel;
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < p; j++)
                {
                    mel = 0;
                    for (k = 0; k < p; k++)
                        mel = mel + m_a[i, k] * m_b[k, j];
                    m_r[i, j] = mel;

                }
            }
        }
    }
}
