using System;
using Tyuiu.KuzakinSI.Sprint4.Task1.V9.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8. Подсчитать произведение *");
            Console.WriteLine("* чётных элементов массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];
            Console.WriteLine("Введите 13 элементов массива (значения от 3 до 8):");

            for (int i = 0; i < 13; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                
                // Проверка диапазона
                while (array[i] < 3 || array[i] > 8)
                {
                    Console.Write("Ошибка! Введите значение от 3 до 8: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Введенный массив: {" + string.Join(", ", array) + "}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Произведение чётных элементов массива = {result}");

            Console.ReadLine();
        }
    }
}