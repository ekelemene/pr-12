using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /// <summary>
        /// Дополнительный метод
        /// </summary>
        /// <param name="x">x</param>
        /// <returns>Значение выражение</returns>
        //public static double Func(int x)  //Задание 1
        //{
        //    return (Math.Sqrt(x) + x) / 2;
        //}

        //public static double Func1(int x, int y) //Задание 2
        //{
        //    return (Math.Sqrt(x) + x) / (Math.Sqrt(y) + y);
        //}

        public static int Max (int x, int y) //Задание 3
        {
            return x>y ? x : y;
        }





        /// <summary>
        /// Основной метод
        /// </summary>
        /// <param name="args">строковый массив</param>
        static void Main(string[] args)
        {

            //Задача 1. Вычислить значение выражения, определив и использовав дополнительный метод:
            //double y = Func(5) + Func(12) + Func(19);
            //Console.WriteLine($"y = {Func(5) + Func(12) + Func(19)}");

            ////Задача 2. Вычислить значение выражения, определив и использовав дополнительный метод:
            //double a = Func1(5, 7) + Func1(12, 8) + Func1(19, 2);
            //Console.WriteLine($"a = {a}");
            //Console.Read();

            //Задание 3 Найти максимальную величину из двух целых переменных a, b с использованием вспомогательных методов.
            Console.Write("Введите x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y = ");
            int y = int.Parse(Console.ReadLine());
            Max(x, y);
            Console.WriteLine($"{Max(x, y)}");
            Console.ReadLine();
        }
    }
}
