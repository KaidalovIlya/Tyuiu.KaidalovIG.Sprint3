using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint3.Task3.V5.Lib;

namespace Tyuiu.KaidalovIG.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharlnString()
        {
            DataService ds = new DataService();

            string art = "fifa al fall";
            char andr = 'a';
            char tim = '*';

            string res = ds.ReplaceCharInString(art, andr, tim);
            string wait = "fif* *l f*ll";
            Assert.AreEqual(wait, res);
        }
    }
}
