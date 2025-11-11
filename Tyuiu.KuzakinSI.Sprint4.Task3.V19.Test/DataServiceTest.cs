using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint4.Task3.V19.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 6, 5, 6, 3, 8 },
                { 9, 4, 4, 3, 4 },
                { 3, 3, 6, 8, 6 },
                { 6, 5, 3, 4, 3 },
                { 9, 3, 5, 3, 7 }
            };

            int result = ds.Calculate(array);
            int wait = 11;

            Assert.AreEqual(wait, result);
        }
    }
}