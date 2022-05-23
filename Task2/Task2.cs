// 2. Дана дійсна матриця A порядку (nxn).
// Елементи головної діагоналі матриці замінити найбільшим елементом протилежної діагоналі.
using System;

namespace chupov2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Неправильне значення n, n > 0");
            }
            else
            {
                double[,] a = new double[n,n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Введіть значення a[{i+1},{j+1}]: ");
                        a[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }

                Console.WriteLine("Матриця: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{a[i, j]} ");
                    }
                    Console.WriteLine();
                }

                double max = 0;

                for (int i = n - 1, j = 0; i >= 0; i--, j++)
                {
                    if (max < a[j, i])
                    {
                        max = a[j, i];
                    }
                }

                Console.WriteLine($"Максимальне значення: {max}");
               
                for (int i = 0; i < n; i++)
                {
                    a[i, i] = max;
                }

                Console.WriteLine("Матриця: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{a[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
