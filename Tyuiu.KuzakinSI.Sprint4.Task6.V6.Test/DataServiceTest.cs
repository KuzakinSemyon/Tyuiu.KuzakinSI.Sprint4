using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KuzakinSI.Sprint4.Task6.V6.Lib;

namespace Tyuiu.KuzakinSI.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = ["Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег"];
            string[] result = ds.Calculate(array);
            string[] wait = ["Борис", "Олег"];

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateEmpty()
        {
            DataService ds = new DataService();

            string[] array = ["Анна", "Ира", "Петя", "Юля"];
            string[] result = ds.Calculate(array);
            string[] wait = [];

            CollectionAssert.AreEqual(wait, result);
        }
    }
}