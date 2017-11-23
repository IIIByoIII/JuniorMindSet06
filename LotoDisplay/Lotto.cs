using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace LottoDisplay
{
    public struct Lotto
    {
        public static int[] LottoNumbers(int[] numbers, int toShow)
        {
            int[] result = new int[toShow];
            Array.Copy(numbers, result, toShow);
            return Insertion.Sort(result);
        }
    }
}
