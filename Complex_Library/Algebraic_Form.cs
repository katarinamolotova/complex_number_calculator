using System;

namespace Complex_Library
{
    class Algebraic_Form : Numbers
    {
        public double A { get; set; }
        public double B { get; set; }
        public Tuple<double, double> Addition() //сложение
        {
            A = A1 + A2;
            B = B1 + B2;
            return Tuple.Create(A, B);
        }
        public Tuple<double, double> Difference() //вычитание
        {
            A = A1 - A2;
            B = B1 - B2;
            return Tuple.Create(A, B);
        }
        public Tuple<double, double> Multiplication() //умножение
        {
            A = A1 * A2 - (B1 * B2);
            B = B1 * A2 + B2 * A1;
            return Tuple.Create(A, B);
        }
        public Tuple<double, double> Division() //деление
        {
            if (A != 0 && B != 0)
            {
                A = Math.Round((A1 * A2 + B1 * B2) / (A2 * A2 * B2 * B2), 2);
                B = Math.Round((B1 * A2 - A1 * B2) / (A2 * A2 * B2 * B2), 2);
                return Tuple.Create(A, B);
            }
            else
            {
                return Tuple.Create(0.0, 0.0);
            }
        }
        public Tuple<double, double> QuadraticEqution(int a, int b, int c)
        {
            A = b / (2 * a);
            B = Math.Round(Math.Pow(Math.Abs(b * b - 4 * a * c), 0.5) / (2 * a), 2);
            return Tuple.Create(A, B);
        }
        public Tuple<double, double> Translation() //перевод
        {
            A = Math.Round(R1 * Math.Cos(Angle1), 2);
            B = Math.Round(R1 * Math.Sin(Angle1), 2);
            return Tuple.Create(A, B);
        }
    }
}
