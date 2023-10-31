using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint4.Task2.V14.Lib;


namespace Tyuiu.KonyushevskyAA.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] lol = { 4, 9, 2, 3, 7, 1 };

            int res = ds.Calculate(lol);
            int wait = 189;

            Assert.AreEqual(wait, res);
        }
    }
}
