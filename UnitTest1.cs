using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPriceCorrect()
        {
            double answer = 2;
            Assert.AreEqual(Oleg.MainClass.For4(), answer);

        }
        [TestMethod]
        public void IsAnswercorrect()
        {
            int answer = 151200;
            Assert.AreEqual(Oleg.MainClass.For8(), answer);
        }
        [TestMethod]
        public void Zeroorone()
        {
            
            int answer = 1;
            Assert.AreEqual(Oleg.MainClass.While4(), answer);
        }
    }
}
