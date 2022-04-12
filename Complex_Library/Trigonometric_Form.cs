using System;

namespace Complex_Library
{
    class Trigonometric_Form : Numbers
    {
        public double R { get; set; }
        public double Angle { get; set; }
        public Tuple<double, double> Multiplication() //умножение
        {
            Angle = Angle1 + Angle2;
            while (Angle > 360) Angle -= 360;
            R = R1 * R2;
            return Tuple.Create(Angle, R);
        }
        public Tuple<double, double> Division() //деление
        {
            if (R != 0)
            {
                Angle = Angle1 - Angle2;
                R = R1 / R2;
                return Tuple.Create(Angle, R);
            }
            else
            {
                return Tuple.Create(Angle, 0.0);
            }
        }
        public Tuple<double, double> Degree() //степень
        {
            Angle = Angle1 * N;
            while (Angle > 360) Angle -= 360;
            R = Math.Pow(R1, N);
            return Tuple.Create(Angle, R);
        }
        public void Root() //корень
        {
            if(R1 < 0 && N % 2 == 0)
            {
                Console.WriteLine("Ошибка: четный корень отрицательного числа");
            }
            else
            {
                Console.WriteLine("Выводится в градусах");
                for (int i = 0; i < N; i++)
                {
                    Angle = Math.Round((Angle1 + 360 * i) / N, 2);
                    R = Math.Round(Math.Pow(R1, 1 / N), 2);
                    Console.WriteLine($"{R}(cos({Angle}) + isin({Angle}))");
                }
            }
        }
        public Tuple<double, double> Translation() //перевод
        {
            double C;
            R = Math.Round(Math.Pow(A1 * A1 + B1 * B1, 0.5), 2);
            C = Math.Round(B1 / A1, 2);
            if (A1 > 0 & B1 >= 0) Angle = Math.Round(Math.Atan(C), 2);
            else if (A1 < 0 & B1 >= 0) Angle = Math.Round(Math.PI - Math.Atan(C), 2);
            else if (A1 < 0 & B1 < 0) Angle = Math.Round(Math.PI + Math.Atan(C), 2);
            else if (A1 > 0 & B1 > 0) Angle = Math.Round(-Math.Atan(Math.Abs(C)), 2);
            else if (A1 == 0 & B1 > 0) Angle = Math.Round(Math.PI / 2, 2);
            else if (A1 == 0 & B1 < 0) Angle = Math.Round(3 * Math.PI / 2, 2);
            Angle = Math.Round(Angle * 180 / Math.PI, 0);
            return Tuple.Create(Angle, R);
        }
    }
}
