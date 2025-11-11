using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint4.Task1.V9.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };
            int result = ds.Calculate(array);
            int wait = 6 * 6 * 4 * 4 * 8; // 6 * 6 = 36, 36 * 4 = 144, 144 * 4 = 576, 576 * 8 = 4608

            Assert.AreEqual(wait, result);
        }
    }
}