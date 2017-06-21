using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Quick : SortHelperfunctions
    {
        private static int Partition(IComparable[] a, int lo, int hi)
        {
            int i = lo, j = hi + 1;
            while (true)
            {
                while (Less(a[++i], a[lo]))
                {
                    if (i == hi) break;
                }

                while (Less(a[lo], a[--j]))
                {
                    if (j == lo) break;
                }

                if (i >= j) break;
                Exchange(a, i, j);
            }

            Exchange(a, i, j);
            return j;
        }

        public static void Sort(IComparable[] a)
        {
            Shuffle(a);
            Sort(a, 0, a.Length -1);
        }

        public static void Sort(IComparable[] a, int lo, int hi)
        {
            //if (hi <= lo) return; Improve..
            if (hi <= lo + 10)
            {
                Insertion.Sort(a, lo, hi);
                return;
            }
            int j = Partition(a, lo, hi);
            Sort(a, lo, j-1);
            Sort(a, j+1, hi);
        }
    }
}
