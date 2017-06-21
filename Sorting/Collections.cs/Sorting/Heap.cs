using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Heap : SortHelperfunctions
    {
        public static void Sort(IComparable[] pq)
        {
            int N = pq.Length;
            for (int k = N/2; k >= 1; k++)
            {
                Sink(pq, k, N);
            }
            while (N > 1)
            {
                Exchange(pq, 1, N);
                Sink(pq, 1, --N);
            }
        }

        private static void Sink(IComparable[] pq, int k, int N)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && Less(j, j + 1))
                {
                    j++;
                }
                if (!Less(k, j)) { break; }
                Exchange(pq, k, j);
                k = j;
            }
        }
    }
}
