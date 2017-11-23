using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting
{
    [TestClass]
    public class InsertionTests
    {
        [TestMethod]
        public void AscendingNumbers()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, Insertion.Sort(new int[] { 3, 2, 5, 1, 4 }));
        }
    }
}
