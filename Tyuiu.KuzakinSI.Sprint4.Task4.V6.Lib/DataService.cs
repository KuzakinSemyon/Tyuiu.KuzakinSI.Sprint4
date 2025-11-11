using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KuzakinSI.Sprint4.Task4.V6.Lib
{
    public class DataService : ISprint4Task4V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0) // Проверка на нечетность
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}