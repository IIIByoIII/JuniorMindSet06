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
            int[,] var = new int[0, 0];
            return Sort(nr, 1, 1, ref var, -1);
        }

        static int[] Sort(int[] nr, int j, int k, ref int[,] array2D, int nth)
        {
            if (k == nr.Length) return nr;
            if (j == 0) {
                k++;
                return Sort(nr, k, k, ref array2D, nth);
            }
            if (nr[j] < nr[j - 1]) {
                nr = Swap(nr, j - 1, j);
                if (nth > -1) array2D = Swap2D(array2D, j - 1, j);
                j--;
                return Sort(nr, j, k, ref array2D, nth);
            }
            k++;
            return Sort(nr, k, k, ref array2D, nth);
        }

        static int[] Swap(int[] element, int a, int b)
        {
            int temp = element[a];
            element[a] = element[b];
            element[b] = temp;
            return element;
        }

        public static int[,] Sort2D(int[,] array2D, int nth)
        {
            int[] nr = new int[array2D.GetLength(0)];
            for (int i = 0; i < array2D.GetLength(0); i++)
                nr[i] = array2D[i,nth];
            Sort(nr, 1, 1, ref array2D, nth);
            return array2D;
        }

        static int[,] Swap2D(int[,] element, int a, int b)
        {
            int temp = element[a,0];
            element[a,0] = element[b,0];
            element[b,0] = temp;
            temp = element[a,1];
            element[a,1] = element[b,1];
            element[b,1] = temp;
            return element;
        }
    }
}
