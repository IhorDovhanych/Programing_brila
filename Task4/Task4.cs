using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1_programB
{
    class Program
    {
        static void Main(string[] args)
        {
            TSquare s1 = new TSquare();
            TSquare s2 = new TSquare(6);
            TSquare s3 = new TSquare(s1);

            Console.WriteLine($"Площа : {s1.SquareSpace()}");
            Console.WriteLine($"Периметер : {s1.SquarePerimeter()}");

            Console.WriteLine($"s1 == s2 : {s1.IsEqual(s2)}");
            Console.WriteLine($"s1 == s3 : {s1.IsEqual(s3)}");

            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");
            Console.WriteLine($"s3 = {s3}");
        }
    }
    class TSquare
    {
        private double a;

        public double A { get { return a; } set { a = value; } }
        public TSquare(double a)
        {
            this.a = a;
        }
        public TSquare()
        {
            a = 5;
        }
        public TSquare(TSquare f)
        {
            this.a = f.a;
        }
        public double SquareSpace()
        {
            return a * a;
        }
        public double SquarePerimeter()
        {
            return a * 4;
        }
        public bool IsEqual(TSquare b)
        {
            return a == b.A && b.A == a;
        }
        public static TSquare operator + (TSquare a1, TSquare a2)
        {
            return new TSquare(a1.A + a2.A);
        }
        public static TSquare operator -(TSquare a1, TSquare a2)
        {
            return new TSquare(a1.A - a2.A);
        }
        public static TSquare operator *(TSquare a1, TSquare a2)
        {
            return new TSquare(a1.A * a2.A);
        }
        public override string ToString()
        {
            return string.Format(Convert.ToString(A));
        }
    }
}