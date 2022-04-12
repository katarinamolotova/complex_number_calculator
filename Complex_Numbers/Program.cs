using System;
using Complex_Library;

namespace Complex_Numbers
{
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            bool run = true;
            while (run == true)
            {
                try
                {
                    Console.WriteLine("Выберите форму комплексного числа:");
                    Console.WriteLine("1. Алгебраическая \t2. Тригонометрическая \t  3. Выход");
                    int command = int.Parse(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            Console.WriteLine("Выберите операцию:");
                            Console.WriteLine("1. Сложение \t2. Вычитание \t\t\t3. Умножение \n" +
                                "4. Деление \t5. Квадратное уравнение \t6. Перевод из триг. формы");
                            command = int.Parse(Console.ReadLine());
                            switch (command)
                            {
                                case 1:
                                    calculator.Algebra1(command);
                                    break;
                                case 2:
                                    calculator.Algebra1(command);
                                    break;
                                case 3:
                                    calculator.Algebra1(command);
                                    break;
                                case 4:
                                    calculator.Algebra1(command);
                                    break;
                                case 5:
                                    calculator.Algebra2();
                                    break;
                                case 6:
                                    calculator.Algebra3();
                                    break;
                                default:
                                    Console.WriteLine("Неверный ввод");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Выберите операцию:");
                            Console.WriteLine("1. Умножение \t2. Деление \t3. Возведение в степень " +
                                "\n4. Корень \t5. Перевод из алг. формы");
                            command = int.Parse(Console.ReadLine());
                            switch (command)
                            {
                                case 1:
                                    calculator.Trigonometrica1(command);
                                    break;
                                case 2:
                                    calculator.Trigonometrica1(command);
                                    break;
                                case 3:
                                    calculator.Trigonometrica2(command);
                                    break;
                                case 4:
                                    calculator.Trigonometrica2(command);
                                    break;
                                case 5:
                                    calculator.Trigonometrica3();
                                    break;
                                default:
                                    Console.WriteLine("Неверный ввод");
                                    break;
                            }
                            break;
                        case 3:
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }
          
            }
        }
    }
}
