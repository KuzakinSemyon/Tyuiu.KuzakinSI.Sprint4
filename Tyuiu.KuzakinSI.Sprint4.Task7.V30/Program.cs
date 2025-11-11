using System;
using Tyuiu.KuzakinSI.Sprint4.Task7.V30.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '684259137159648'. Преобразуйте ее   *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 5;
            int m = 3;
            string value = "684259137159648";
            
            Console.WriteLine($"Количество строк (n) = {n}");
            Console.WriteLine($"Количество столбцов (m) = {m}");
            Console.WriteLine($"Исходная строка = {value}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(n, m, value);
            Console.WriteLine($"Произведение четных чисел = {result}");

            Console.ReadLine();
        }
    }
}