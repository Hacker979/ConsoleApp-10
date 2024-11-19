using System;

namespace ConsoleApp_10
{
    class Program
    {
        static void gg()
        {
            Console.WriteLine(((Math.Sqrt(5) + 5) / 2) + ((Math.Sqrt(12) + 12) / 2) + ((Math.Sqrt(19) + 19) / 2));
        }

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Строковый массив аргументов командной строки</param>
        static void Main(string[] args)
        {
            // Call gg() method
            gg();
            Console.Read();
        }
    }
}
