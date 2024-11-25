using System;

namespace ConsoleApp_10
{
    class Program
    {
        // Задание 1: Вычисление выражения
        static double Expression1()
        {
            return ((Math.Sqrt(5) + 5) / 2) + ((Math.Sqrt(12) + 12) / 2) + ((Math.Sqrt(19) + 19) / 2);
        }

        // Задание 2: Вычисление другого выражения
        static double Expression2()
        {
            return ((Math.Sqrt(5) + 5) / (Math.Sqrt(7) + 7)) + ((Math.Sqrt(12) + 12) / (Math.Sqrt(8) + 8)) + ((Math.Sqrt(19) + 19) / (Math.Sqrt(2) + 2));
        }

        // Задание 3: Нахождение максимума из двух чисел
        static int Max2(int a, int b)
        {
            return a > b ? a : b;
        }

        // Задание 4: Нахождение максимума из трех чисел
        static int Max3(int a, int b, int c)
        {
            return Max2(Max2(a, b), c);
        }

        // Задание 5: Нахождение суммы максимума двух пар чисел
        static int SumMax(int a, int b, int c, int d)
        {
            return Max2(a, b) + Max2(c, d);
        }

        // Задание 6: Вывод дня недели по номеру
        static string DWk(int dayN)
        {
            switch (dayNumber)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "Неверный номер дня";
            }
        }

        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine(Expression1());

            // Задание 2
            Console.WriteLine(Expression2());

            // Задание 3
            int a = 5, b = 10;
            Console.WriteLine(Max2(a, b));

            // Задание 4
            int c = 3;
            Console.WriteLine(Max3(a, b, c));

            // Задание 5
            int d = 7;
            Console.WriteLine(SumMax(a, b, c, d));

            // Задание 6
            int dayN = 3; // среда
            Console.WriteLine(DW(dayN));

            Console.ReadLine();
        }
    }
}
