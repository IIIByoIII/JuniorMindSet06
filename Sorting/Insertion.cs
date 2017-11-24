using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Insertion
    {
        public static int[] Sort(int[] nr)
        {
            return Sort(nr, 1, 1);
        }

        static int[] Sort(int[] nr, int j, int k)
        {
            if (k == nr.Length) return nr;
            if (j == 0) {
                k++;
                return Sort(nr, k, k);
            }
            if (nr[j] < nr[j - 1]) {
                nr = Swap(nr, j - 1, j);
                j--;
                return Sort(nr, j, k);
            }
            k++;
            return Sort(nr, k, k);
        }

        static int[] Swap(int[] element, int a, int b)
        {
            int temp = element[a];
            element[a] = element[b];
            element[b] = temp;
            return element;
        }
    }
}
