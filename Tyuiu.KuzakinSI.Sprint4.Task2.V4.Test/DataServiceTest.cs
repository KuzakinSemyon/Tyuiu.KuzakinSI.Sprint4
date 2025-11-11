using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint4.Task2.V4.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6 };
            int result = ds.Calculate(array);
            int wait = 3 + 5 + 7 + 9 + 3 + 5; // 32

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateAllEven()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 8, 2, 4, 6, 8, 2, 4, 6, 8, 2 };
            int result = ds.Calculate(array);
            int wait = 0; // Все элементы четные

            Assert.AreEqual(wait, result);
        }
    }
}