using System;

namespace chupov3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            var m = new Matrix(n);
            m.InputMatrix();
            Console.WriteLine($"Max : {m.GetMax()}\n");
            Console.WriteLine(m);
        }
    }

    class Matrix
    {
        private double[,] _matrix;
        private int _n;
        public Matrix(double[,] matrix, int n)
        {
            _matrix = matrix;
            _n = n;
        }
        public Matrix(int n)
        {
            _n = n;
            _matrix = new double[_n, _n];
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _matrix[i, j] = 0;
                }
            }
        }
        public Matrix()
        {
            _n = 2;
            _matrix = new double[2,2];
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _matrix[i, j] = 0;
                }
            }
        }
        public Matrix(Matrix f)
        {
            _matrix = f._matrix;
            _n = f._n;
        }

        public double[,] ActMatrix
        {
            get { return _matrix; }
            set { _matrix = value; }
        }
        public int N
        {
            get { return _n; }
            set { _n = value; }
        }

        public void InputMatrix()
        {
            for(int i = 0; i < _n; i++)
            {
              for (int j = 0; j < _n; j++)
                {
                    Console.Write($"el {i + 1} {j + 1} : ");
                    _matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public double GetMax()
        {
            double _max = _matrix[0,0];
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (_max < _matrix[i, j])
                        _max = _matrix[i, j];
                }
            }
            return _max;
        }

        public double GetMin()
        {
            double _min = _matrix[0, 0];
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (_min > _matrix[i, j])
                        _min = _matrix[i, j];
                }
            }
            return _min;
        }

        public override string ToString()
        {
            string _stringMatrix = "";
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _stringMatrix += Convert.ToString(_matrix[i, j]) + " ";
                }
                _stringMatrix += "\n";
            }
            return string.Format($"Matrix: \n{_stringMatrix}\nn : {_n}");
        }
    }
}
