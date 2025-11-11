using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint4.Task5.V19.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { 2, 0, -1, 3, 1 },
                { -2, 3, 1, -1, 2 },
                { 1, -2, 3, 0, 2 },
                { -1, 2, 1, 3, -2 },
                { 3, 1, -2, 2, 0 }
            };

            int result = ds.Calculate(matrix);
            int wait = 15; // Положительные элементы: > 0

            Assert.AreEqual(wait, result);
        }
    }
}