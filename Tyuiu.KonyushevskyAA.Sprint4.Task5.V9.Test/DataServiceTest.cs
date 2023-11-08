using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint4.Task5.V9.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]{ { -4, -3, -2, -1, 0 },
                                         { 1, 2, 3, 4, 4 },
                                         { 4, -4, -3, -2, -1 },
                                         { 0, 1, 2, 3, 4 },
                                         { 3, 4, -4, -3, -2 } };

            int res = ds.Calculate(mas2);
            int wait = 12;

            Assert.AreEqual(wait, res);
        }
    }
}
