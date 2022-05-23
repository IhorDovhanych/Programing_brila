using System;

namespace chupov3
{
    class Program
    {
        static void Main(string[] args)
        {
            TCube c1 = new TCube(12, 6, 5);
            TCube c2 = new TCube(3);
            TCube c3 = new TCube();
            TCube c4 = new TCube(c1);

            Console.WriteLine($"c1 = \n{c1}");
            Console.WriteLine($"c1 + c2 = \n{c1 + c2}");
            Console.WriteLine($"c1 - c2= \n{c1 - c2}");
            Console.WriteLine($"c1 * c2= \n{c1 * c2}");
            //Console.WriteLine($"c2 - c1 = \n{c2 - c1}");
        }
    }

    class TSquare
    {
        protected double _a, _b;
        public double a { get { return _a; } set { _a = value; } }
        public double b { get { return _b; } set { _b = value; } }
        public TSquare(double a, double b)
        {
            if (a >= 0 && b >= 0)
            {
                this.a = a;
                this.b = b;
            }
            else throw new Exception("Довжина не може бути відємною");
        }
        public TSquare(double a)
        {
            if (a >= 0)
            {
                this.a = a;
                this.b = a;
            }
            else throw new Exception("Довжина не може бути відємною");
        }
        public TSquare()
        {
            this.a = 2;
            this.b = 2;
        }
        public TSquare(TSquare f)
        {
            if (f.a >= 0 && f.b >= 0)
            {
                this.a = f.a;
                this.b = f.b;
            }
            else throw new Exception("Довжина не може бути відємною");
        }
        public double GetSpace()
        {
            return a * b;
        }
        public double GetPerimeter()
        {
            return (a + b) * 2;
        }
        public bool DoEqual(TSquare f)
        {
            if (a == f.a && b == f.b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static TSquare operator +(TSquare s1, TSquare s2)
        {
            return new TSquare(s1.a + s2.a, s1.b + s2.b);
        }
        public static TSquare operator -(TSquare s1, TSquare s2)
        {
            if (s1.a - s2.a! < 0 && s1.b - s2.b! < 0)
                return new TSquare(s1.a - s2.a, s1.b - s2.b);
            else throw new Exception("Довжина не може бути відємною");
        }
        public static TSquare operator *(TSquare s1, TSquare s2)
        {
            return new TSquare(s1.a * s2.a, s1.b * s2.b);
        }
        public override string ToString()
        {

            return string.Format($"a = {a}\n" +
                $"b = {b}\n" +
                $"Площа = {GetSpace()}" +
                $"Периметер = {GetPerimeter()}");
        }


    }
    class TCube : TSquare
    {
        protected double _c;
        public double c { get { return _c; } set { _c = value; } }

        public TCube(double a, double b, double c) : base(a, b)
        {
            if (a >= 0 && b >= 0 && c >= 0)
                this.c = c;
            else throw new Exception("Довжина не може бути відємною");
        }
        public TCube(double a) : base(a)
        {
            if (a >= 0)
                this.c = a;
            else throw new Exception("Довжина не може бути відємною");
        }
        public TCube() : base()
        {
            this.c = 2;
        }
        public TCube(TCube f) : base(f.a, f.b)
        {
            if (f.c >= 0)
                this.c = f.c;
            else throw new Exception("Довжина не може бути відємною");
        }
        public double GetVolume()
        {
            return a * b * c;
        }
        public static TCube operator +(TCube s1, TCube s2)
        {
            return new TCube(s1.a + s2.a, s1.b + s2.b, s1.c + s2.c);
        }
        public static TCube operator -(TCube s1, TCube s2)
        {
            if (s1.a - s2.a! < 0 && s1.b - s2.b! < 0 && s1.c - s2.c < 0)
                return new TCube(s1.a - s2.a, s1.b - s2.b, s1.c - s2.c);
            else throw new Exception("Довжина не може бути відємною");
        }
        public static TCube operator *(TCube s1, TCube s2)
        {
            return new TCube(s1.a * s2.a, s1.b * s2.b, s1.c * s2.c);
        }
        public override string ToString()
        {

            return string.Format($"a = {a}\n" +
                $"b = {b}\n" +
                $"Площа = {GetSpace()}" +
                $"Периметер = {GetPerimeter()}" +
                $"Об'єм = {GetVolume()}");
        }
    }
}
