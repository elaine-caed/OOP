using System;
namespace ConsoleApplication
{
    class Program
    {
        class Array

        {
            static void Main()
            {
                int[,] C = { { 3, 6, 4, 7 }, { 6, 2, 8, 4 }, { 4, 8, 1, 6 }, { 7, 4, 6, 0 } };
                int[,] D = { { 1, 3, 0 }, { 3, 2, 6 }, { 0, 6, 5 } };
                printarray(C);
                symNcount(C);
                Console.WriteLine();
                printarray(D);
                symNcount(D);
                Console.WriteLine();
                int[,] C1 = array(4, 4);
                int[,] D1 = array(3, 3);
                printarray(C1);
                symNcount(C1);
                Console.WriteLine();
                printarray(D1);
                symNcount(D1);
            }
            static int[,] array(int n, int m)
            {
                Random r = new Random();
                int[,] array = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = r.Next(0, 10);
                    }
                }
                return array;
            }
            static void printarray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            static void symNcount(int[,] array)
            {
                int count = 0, a = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] == array[j, i])
                        {
                            count++;
                        }
                        if (i != j)
                        {
                            a += array[i, j];
                        }
                    }
                }
                int k = array.GetLength(0) * array.GetLength(1);
                if (count == k)
                {
                    Console.WriteLine($"Array is symmetrical! Congratulations!");
                    Console.WriteLine($"Sum of all elements outside the main diagonal: {a}");
                }
                else
                {
                    Console.WriteLine($"Array is not symmetrical");
                }
            }
        }
    }
}