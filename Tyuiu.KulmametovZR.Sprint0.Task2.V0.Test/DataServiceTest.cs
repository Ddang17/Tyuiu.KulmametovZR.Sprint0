using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulmametovZR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KulmametovZR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Заур";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Заур", res);
        }
    }
}
