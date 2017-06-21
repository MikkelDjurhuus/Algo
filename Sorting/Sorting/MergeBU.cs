using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeBU : SortHelperfunctions
    {
        private static IComparable[] aux;

        private static void Merge(IComparable[] a, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    a[k] = aux[j++];
                }
                else if (j > hi)
                {
                    a[k] = aux[i++];
                }
                else if (Less(aux[j], aux[i]))
                {
                    a[k] = aux[j++];
                }
                else
                {
                    a[k] = aux[i++];
                }
            }
        }

        public static void Sort(IComparable[] a)
        {
            int N = a.Length;
            aux = new IComparable[N];
            for (int sz = 0; sz < N; sz += sz)
            {
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                {
                    Merge(a, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
                }
            }
        }
    }
}
