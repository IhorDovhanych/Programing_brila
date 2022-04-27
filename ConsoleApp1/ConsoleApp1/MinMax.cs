using System;

// Довганич Ігор Олегович/ Варіант 3/ Завдання 1 та 2

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення n (n>100)");
            int n = Convert.ToInt32(Console.ReadLine()), m = n, max1 = 0, max2, count=0, position=1;
            if (n > 100)
            {
                while (n != 0)
                {
                    count++;
                    max2 = n % 10;
                    if (max2 > max1)
                    {
                        max1 = max2;
                        position = count;
                    }
                    n /= 10;
                }
                n = m;
                m = n % (10 * count);
                

                for (int i=0; i>count; i++)
                {

                }
  
            }
            else Console.WriteLine("Неправильне значення n");

        }
    }
}   