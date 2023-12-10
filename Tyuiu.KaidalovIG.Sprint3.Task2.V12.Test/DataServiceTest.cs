using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint3.Task2.V12.Lib;

namespace Tyuiu.KaidalovIG.Sprint3.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 5;
            Assert.AreEqual(0.033, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
