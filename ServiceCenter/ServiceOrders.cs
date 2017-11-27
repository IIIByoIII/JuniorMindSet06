using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter
{
    public class Service
    {
        public static int[,] Orders(int[] pr)
        {
            int[,] result = new int[pr.Length, 2];
            for (int i = 0; i < pr.Length; i++) {
                result[i, 0] = i + 1;
                result[i, 1] = pr[i];
            }
            return result;
        }
    }
}
