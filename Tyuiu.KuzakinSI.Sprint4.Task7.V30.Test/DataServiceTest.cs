using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint4.Task7.V30.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "684259137159648";

            int result = ds.Calculate(n, m, value);
            int wait = 6 * 8 * 4 * 2 * 6 * 4 * 8; // 73728

            Assert.AreEqual(wait, result);
        }
    }
}