using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint4.Task0.V5.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int result = ds.GetSumEvenArrEl(array);
            int wait = 8 + 4 + 2 + 4 + 6; // 24

            Assert.AreEqual(wait, result);
        }
    }
}