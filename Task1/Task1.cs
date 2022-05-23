// 1. Дано вектор дійсних чисел a є R^n. отримати min(a1+a2,a2+a3,...,an-1+an)
using System;

namespace chupov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Не правильне значення n, n > 0");
            }
            else
            {
                double[] a = new double[n];
                double[] b = new double[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введіть {i + 1} значення: ");
                    a[i] = Convert.ToDouble(Console.ReadLine());
                }

                for (int i = 1; i < n; i++)
                {
                    b[i - 1] = a[i - 1] + a[i];
                }

                b = DeleteElementByIndex(b, n - 1);

                double min = b[0];

                for (int i = 0; i < n - 1; i++)
                {
                    if (b[i] < min)
                        min = b[i];
                }
                Console.WriteLine(min);
            }
        }
        public static double[] DeleteElementByIndex( double[] arr, int index)
        {
            double[] newArray = new double[arr.Length - 1];
            int j = 0;
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (i == index)
                {
                    i++;
                }
                newArray[j] = arr[i];
                j++;
            }
            return newArray;
        }
    }
}
