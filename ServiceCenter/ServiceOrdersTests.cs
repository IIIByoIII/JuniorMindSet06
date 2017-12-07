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

        [TestMethod]
        public void SortedOrdersAndPriorities()
        {
            int[] priorities = new int[] { 2, 1, 3, 2, 1 };
            int[,] result = new int[,] {{ 2, 1 }, { 5, 1 }, { 1, 2 }, { 4, 2 }, { 3, 3 }}; 
            CollectionAssert.AreEqual(result, Service.OrderedPriorities(priorities));
        }
    }
}
