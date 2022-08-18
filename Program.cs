using System;


namespace SquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            char check;
            SquareEquation equation = new SquareEquation();
            do
            {
                Console.Clear();
                do
                {
                    Console.Write("A = ");
                    a = Convert.ToDouble(Console.ReadLine());
                } while (a == 0);
                equation.A = a;

                Console.Write("B = ");
                equation.B = Convert.ToDouble(Console.ReadLine());

                Console.Write("C = ");
                equation.C = Convert.ToDouble(Console.ReadLine());

                SquareEquation equation1 = new SquareEquation(equation.A, equation.B, equation.C);
                Console.WriteLine("If you want to calculate one more square equation choose: (y/n)");
                check = Convert.ToChar(Console.ReadLine());
            } while (check == 'y');
        }
    }
    class SquareEquation
    {
        private double _a;
        public SquareEquation()
        {

        }
        public SquareEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            double d = Math.Pow(B, 2) - 4 * A * C;
            Console.WriteLine($"D = {d}");
            if (d >= 0)
            {
                double x1 = (-B - Math.Sqrt(d)) / (2 * A);
                double x2 = (-B + Math.Sqrt(d)) / (2 * A);

                Console.WriteLine($"X1 = {x1}");
                Console.WriteLine($"X2 = {x2}");
            }
            else
            {
                Console.WriteLine("No roots found.");
            }
        }
        public double A
        {
            get
            {
                if (_a == 0)
                {
                    throw new Exception("A can't be zero");
                }

                return _a;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("A can't be zero");
                }
                _a = value;
            }
        }
        public double B { get; set; }
        public double C { get; set; }
    }
}
