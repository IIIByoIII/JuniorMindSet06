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

        [TestMethod]
        public void AscendingSafe2DArray()
        {
            int[,] random2DArray = new int[,] {{ 1, 2 }, { 2, 3 }, { 3, 2 }, { 4, 1 }, { 5, 2 }};
            int[,] sorted2DArray = new int[,] {{ 4, 1 }, { 1, 2 }, { 3, 2 }, { 5, 2 }, { 2, 3 }};
            CollectionAssert.AreEqual(sorted2DArray, Insertion.Sort2D(random2DArray, 1));
        }
    }
}
