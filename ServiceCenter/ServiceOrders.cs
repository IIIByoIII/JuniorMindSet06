using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace ServiceCenter
{
    public struct Order
    {
        public int pr;
        public string name;

        public Order(int priority, string clientName)
        {
            pr = priority;
            name = clientName;
        }
    }

    public class Service
    {
        public static Order[] OrderedStruct(Order[] orders)
        {
            int[] priorities = new int[orders.Length];
            for (int i = 0; i < orders.Length; i++)
                priorities[i] = orders[i].pr;
            int[,] prioritiesOrder = OrderedPriorities(priorities);
            Order[] result = new Order[orders.Length];
            for (int i = 0; i < orders.Length; i++)
                result[i] = orders[prioritiesOrder[i,0] - 1];
            return result;
        }

        public static int[,] OrderedPriorities(int[] pr)
        {
            int[,] result = Orders(pr);
            return Insertion.Sort2D(result, 1);
        }

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
