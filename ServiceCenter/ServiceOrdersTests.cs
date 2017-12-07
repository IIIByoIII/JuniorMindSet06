using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceCenter
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void OrdersAndPriorities()
        {
            int[] priorities = new int[] { 2, 1, 3 };
            CollectionAssert.AreEqual(new int[,]{{ 1, 2 }, { 2, 1 }, { 3, 3 }}, Service.Orders(priorities));
        }
    }
}
