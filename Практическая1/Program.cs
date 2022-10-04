using System;
using System.Diagnostics;

namespace MENYAZAEBAALKALYCATOUR
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b;
                string action;

                Console.WriteLine("Выберите действие\n1. Сложить 2 числа\n2. Вычесть второе число из первого\n3. Перемножить два числа\n4. Разделить первое на второе \n5. Возвести в степень N первое число \n6. Найти квадратный корень из числа \n7. Найти 1 процент от числа \n8. Найти факториал из числа \n9. Выйти из программы");
                action = Console.ReadLine();


                switch (action)
                {
                    case "1":
                        Console.WriteLine("Введите первое число: ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите второе число: ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine(a + b);
                        break;

                    case "2":
                        Console.WriteLine("Введите первое число: ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите второе число: ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine(a - b);
                        break;

                    case "3":
                        Console.WriteLine("Введите первое число: ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите второе число: ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine(a * b);
                        break;

                    case "4":
                        Console.WriteLine("Введите первое число: ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите второе число: ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine(a / b);
                        break;

                    case "5":
                        Console.WriteLine("Введите первое число: ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Введите второе число: ");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine(Math.Pow(a, b));
                        break;

                    case "6":
                        Console.WriteLine("Введите число: ");
                        a = double.Parse(Console.ReadLine());
                        double x = Math.Sqrt(a);
                        Console.WriteLine(x);
                        break;

                    case "7":
                        Console.WriteLine("Введите число: ");
                        a = double.Parse(Console.ReadLine());

                        Console.WriteLine(a / 100);
                        break;

                    case "8":
                        Console.WriteLine("Введите число: ");
                        int n = int.Parse(Console.ReadLine());
                        int factorial = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine(factorial);
                        break;

                    case "9":
                        Process.GetCurrentProcess().Kill();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}