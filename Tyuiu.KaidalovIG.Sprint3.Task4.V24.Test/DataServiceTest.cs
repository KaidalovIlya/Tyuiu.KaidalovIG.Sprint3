using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint3.Task4.V24.Lib;

namespace Tyuiu.KaidalovIG.Sprint3.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInStrin()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 4.478;
            Assert.AreEqual(res, wait);

        }
    }
}
