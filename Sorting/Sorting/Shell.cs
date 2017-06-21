using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Shell : SortHelperfunctions
    {
        public static void Sort(IComparable[] a)
        {
            int N = a.Length;

            int h = 1;
            while (h < N / 3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h; j -= h)
                    {
                        if (Less(a[j], a[j - h]))
                        {
                            Exchange(a, j, j - h);
                        }
                    }
                }
            }
        }
    }
}
