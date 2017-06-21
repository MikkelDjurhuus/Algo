﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSelect : SortHelperfunctions
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

        public static IComparable Select(IComparable[] a, int k)
        {
            Shuffle(a);
            int lo = 0, hi = a.Length - 1;
            while (hi > lo)
            {
                int j = Partition(a, lo, hi);
                if (j < k)
                {
                    lo = j + 1;
                }
                else if (j > k)
                {
                    hi = j - 1;
                }
                else
                {
                    return a[k];
                }
            }
            return a[k];
        }
    }
}
