using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Quick3way : SortHelperfunctions
    {
        public static void Sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo + 10)
            {
                Insertion.Sort(a, lo, hi);
                return;
            }

            int lt = lo, gt = hi;
            IComparable v = a[lo];
            int i = lo;

            while (i <= gt)
            {
                int cmp = a[i].CompareTo(v);
                if (cmp < 0)
                {
                    Exchange(a, lt++, i++);
                }
                else if (cmp > 0)
                {
                    Exchange(a, i, gt--);
                }
                else
                {
                    i++;
                }
            }

            Sort(a, lo, lt - 1);
            Sort(a, gt + 1, hi);
        }
    }
}
