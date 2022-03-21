using AlgorithmLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UrTest
{
    [TestClass]
    public class KvLUrTest
    {
        [TestMethod]
        public void TestMethodKvUr1()
        {
            string message_exp = "Прямая совпадает с осью";

            KvLUr.KvUr(0, 0, 0, out string message_act);

            Assert.AreEqual(message_exp, message_act);
        }

        [TestMethod]
        public void TestMethodLUr1()
        {
            string message_exp = "Прямая совпадает с осью";

            KvLUr.LUr(0, 0, out string message_act);

            Assert.AreEqual(message_exp, message_act);
        }

        [TestMethod]
        public void TestMethodKvUr2()
        {
            string message_exp = "Нет корней";

            KvLUr.KvUr(1, 2, 3, out string message_act);

            Assert.AreEqual(message_exp, message_act);
        }

        [TestMethod]
        public void TestMethodLUr2()
        {
            string message_exp = "Корень: x = -2";

            KvLUr.LUr(1, 2, out string message_act);

            Assert.AreEqual(message_exp, message_act);
        }
    }
}

