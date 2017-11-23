using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Insertion
    {
        public static int[] Sort(int[] nr, int j = 1, int k = 1)
        {
            if (k == nr.Length)
                return nr;
            if (j == 0)
            {
                k++;
                return Sort(nr, k, k);
            }
            if (nr[j] < nr[j - 1])
            {
                int t = nr[j - 1];
                nr[j - 1] = nr[j];
                nr[j] = t;
                j--;
                return Sort(nr, j, k);
            }
            k++;
            return Sort(nr, k, k);
        }
    }
}
