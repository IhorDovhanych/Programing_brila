using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("first_num = ");
            int first_num = int.Parse(Console.ReadLine());
            Console.Write("second_num = ");
            int second_num = int.Parse(Console.ReadLine());
            int sum = first_num + second_num;
            Console.WriteLine(sum);

        }
    }
}