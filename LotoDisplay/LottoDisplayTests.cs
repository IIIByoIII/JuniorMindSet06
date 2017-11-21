using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoDisplay
{
    [TestClass]
    public class LottoDisplayTests
    {
        [TestMethod]
        public void AscendingNumbers()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, InsertionSort(new int[] { 3, 2, 5, 1, 4 }));
        }

        int[] InsertionSort(int[] nr, int j = 1, int k = 1)
        {
            if (k == nr.Length)
                return nr;
            if (j == 0) {
                k++;
                return InsertionSort(nr, k, k);
            }
            if (nr[j] < nr[j-1]) {
                int t = nr[j-1];
                nr[j-1] = nr[j];
                nr[j] = t;
                j--;
                return InsertionSort(nr, j, k);
            }
            k++;
            return InsertionSort(nr, k, k);
        }
    }
}
