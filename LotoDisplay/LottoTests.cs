using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LottoDisplay
{
    [TestClass]
    public class LottoTests
    {
        [TestMethod]
        public void LottoAllNumbers()
        {
            int[] numbers = { 35, 43, 40, 5, 3, 29 };
            CollectionAssert.AreEqual(new int[] { 3, 5, 29, 35, 40, 43 }, Lotto.LottoNumbers(numbers, 6));
        }

        [TestMethod]
        public void LottoFirst5()
        {
            int[] numbers = { 35, 43, 40, 5, 3, 29 };
            CollectionAssert.AreEqual(new int[] { 3, 5, 35, 40, 43 }, Lotto.LottoNumbers(numbers, 5));
        }

        [TestMethod]
        public void LottoFirst3()
        {
            int[] numbers = { 35, 43, 40, 5, 3, 29 };
            CollectionAssert.AreEqual(new int[] { 35, 40, 43 }, Lotto.LottoNumbers(numbers, 3));
        }
    }
}
