using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Library
{
    public class Calculator
    {
        public void Algebra1(int n)
        {
            Algebraic_Form algebra = new Algebraic_Form();
            Console.Write("Целая часть первого числа: ");
            algebra.A1 = double.Parse(Console.ReadLine());
            Console.Write("Мнимая часть первого числа: ");
            algebra.B1 = double.Parse(Console.ReadLine());
            Console.Write("Целая часть второго числа: ");
            algebra.A2 = double.Parse(Console.ReadLine());
            Console.Write("Мнимая часть второго числа: ");
            algebra.B2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            if (n == 1) 
            { 
                var pair = algebra.Addition();
                Console.WriteLine($"Действительная часть {pair.Item1} Минимая часть {pair.Item2}");
            }
            else if (n == 2)
            {
                var pair = algebra.Difference();
                Console.WriteLine($"Действительная часть {pair.Item1} Минимая часть {pair.Item2}");
            }
            else if (n == 3)
            {
                var pair = algebra.Multiplication();
                Console.WriteLine($"Действительная часть {pair.Item1} Минимая часть {pair.Item2}");
            }
            else if (n == 4)
            {
                var pair = algebra.Division();
                if (pair.Item1 == 0 && pair.Item2 == 0)
                {
                    Console.WriteLine($"Ошибка: деление на ноль");
                }
                else
                {
                    Console.WriteLine($"Действительная часть {pair.Item1} Минимая часть {pair.Item2}");
                }
            }

        }
        public void Algebra2()
        {
            Algebraic_Form algebra = new Algebraic_Form();
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            var pair = algebra.QuadraticEqution(a, b, c);
            Console.WriteLine("Результат:");
            Console.WriteLine($"Действительная часть {pair.Item1} Минимая часть +- {pair.Item2}");
        }
        public void Algebra3()
        {
            Algebraic_Form algebra = new Algebraic_Form();
            Console.Write("Модуль числа: ");
            algebra.R1 = double.Parse(Console.ReadLine());
            Console.Write("Угол числа: ");
            algebra.Angle1 = double.Parse(Console.ReadLine());
            Console.WriteLine("В чем вы измеряете угол: ");
            Console.WriteLine("1. Градусы\t 2. Радианы");
            int command = int.Parse(Console.ReadLine());
            if (command == 1)
            {
                algebra.Angle1 *= Math.PI / 180; 
            }
            else if(command == 2)
            {
                var pair = algebra.Translation();
                Console.WriteLine("Результат:");
                Console.WriteLine($"Действительная часть {pair.Item1} Минимая часть {pair.Item2}");
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
        public void Trigonometrica1(int n)
        {
            Trigonometric_Form trigonom = new Trigonometric_Form();
            Console.Write("Модуль первого числа: ");
            trigonom.R1 = double.Parse(Console.ReadLine());
            Console.Write("Угол первого числа: ");
            trigonom.Angle1 = double.Parse(Console.ReadLine());
            Console.Write("Модуль второго числа: ");
            trigonom.R2 = double.Parse(Console.ReadLine());
            Console.Write("Угол второго числа: ");
            trigonom.Angle2 = double.Parse(Console.ReadLine());
            Console.WriteLine("В чем вы измеряете угол: ");
            Console.WriteLine("1. Градусы\t 2. Радианы");
            int command = int.Parse(Console.ReadLine());
            if (command == 2)
            {
                Math.Round(trigonom.Angle1 *= 180 / Math.PI, 2);
                Math.Round(trigonom.Angle2 *= 180 / Math.PI, 2);
            }
            Console.WriteLine("Результат:");
            Console.WriteLine("Выводится в градусах");
            if (n == 1)
            {
                var pair = trigonom.Multiplication();
                Console.WriteLine($"{Math.Round(pair.Item2, 2)}(cos({Math.Round(pair.Item1, 0)}) " +
                    $"+ isin({Math.Round(pair.Item1, 0)}))");
            }
            else if (n == 2) 
            {
                var pair = trigonom.Division();
                if (pair.Item1 == 0 && pair.Item2 == 0)
                {
                    Console.WriteLine($"Ошибка: деление на ноль");
                }
                else
                {
                    Console.WriteLine($"{Math.Round(pair.Item2, 2)}(cos({Math.Round(pair.Item1, 0)}) " +
                    $"+ isin({Math.Round(pair.Item1, 0)}))");
                }
            }
        }
        public void Trigonometrica2(int n)
        {
            Trigonometric_Form trigonom = new Trigonometric_Form();
            Console.Write("Модуль числа: ");
            trigonom.R1 = double.Parse(Console.ReadLine());
            Console.Write("Угол числа: ");
            trigonom.Angle1 = double.Parse(Console.ReadLine());
            Console.WriteLine("В чем вы измеряете угол: ");
            Console.WriteLine("1. Градусы\t 2. Радианы");
            int command = int.Parse(Console.ReadLine());
            if (command == 2) Math.Round(trigonom.Angle1 *= 180 / Math.PI, 2);
            Console.Write("Степень: ");
            trigonom.N = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            if (n == 3)
            {

                Console.WriteLine("Выводится в градусах");
                var pair = trigonom.Degree();
                Console.WriteLine($"{Math.Round(pair.Item2, 2)}(cos({Math.Round(pair.Item1, 0)}) " +
                    $"+ isin({Math.Round(pair.Item1, 0)}))");
            }
            else if (n == 4)
            {
                trigonom.Root();
            }
        }

        public void Trigonometrica3()
        {
            Trigonometric_Form trigonom = new Trigonometric_Form();
            Console.Write("Целая часть числа: ");
            trigonom.A1 = double.Parse(Console.ReadLine());
            Console.Write("Мнимая часть числа: ");
            trigonom.B1 = double.Parse(Console.ReadLine());
            var pair = trigonom.Translation();
            Console.WriteLine("Результат:");
            Console.WriteLine("Выводится в градусах");
            Console.WriteLine($"{Math.Round(pair.Item2, 2)}(cos({Math.Round(pair.Item1, 0)}) " +
                $"+ isin({Math.Round(pair.Item1, 0)}))");
        }
    }
}
