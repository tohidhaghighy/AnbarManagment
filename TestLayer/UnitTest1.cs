using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DomainLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestLayer
{
    [TestClass]
    public class UnitTest1
    {
        
        public static List<int> GetListOfIntItems(int numberOfItems)
        {
            List<int> res = new List<int>();
            var mock = new Mock<User>();
            for (int i = 0; i < numberOfItems; i++)
                res.Add(i);

            return res;
        }

        public bool ContainsFarsiData(string txt)
        {
            return !string.IsNullOrEmpty(txt) &&
                    Regex.IsMatch(txt, "[ا-یءئ]");
        }

        public bool ContainsFarsi(string txt)
        {
            return !string.IsNullOrEmpty(txt) &&
                    Regex.IsMatch(txt, @"[\u0600-\u06FF]");
        }

        [TestMethod]
        public void TestGetListOfIntItems()
        {
            const int count = 5;
            List<int> items = GetListOfIntItems(count);
            Assert.AreEqual(items.Count, 5);
        }

        [TestMethod]
        public void TestIsPersion()
        {
            Assert.IsTrue(ContainsFarsi("وحید"));
        }

        [TestMethod]
        public void TestIsPersionData()
        {
            Assert.IsTrue(ContainsFarsiData("۱۳۸۷ُلام"));
        }
    }
}
