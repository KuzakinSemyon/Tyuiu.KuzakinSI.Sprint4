using System;
using Tyuiu.KuzakinSI.Sprint4.Task0.V5.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task0.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму чётных *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Исходный массив: { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetSumEvenArrEl(array);
            Console.WriteLine($"Сумма чётных элементов массива = {result}");

            Console.ReadLine();
        }
    }
}