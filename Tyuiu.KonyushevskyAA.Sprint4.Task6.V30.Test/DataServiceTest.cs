using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint4.Task6.V30.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] trees = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            string[] res = ds.Calculate(trees);

            string[] wait = { "Береза" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
