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

        [TestMethod]
        public void SortedStructOrders()
        {
            Order ord1 = new Order(2, "John");
            Order ord2 = new Order(1, "Janice");
            Order ord3 = new Order(3, "Joe");
            Order ord4 = new Order(2, "Jesse");
            Order ord5 = new Order(1, "James");
            Order[] orders = new Order[] { ord1, ord2, ord3, ord4, ord5 };
            Order[] result = new Order[] { ord2, ord5, ord1, ord4, ord3 };
            CollectionAssert.AreEqual(result, Service.OrderedStruct(orders));
        }
    }
}
