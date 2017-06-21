using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Insertion : SortHelperfunctions
    {
        public static void Sort(IComparable[] a, int lo = -1, int hi = -1)
        {
            int minB = lo > -1 ? lo : 0;
            int maxB = hi > -1 ? hi : a.Length;
            for (int i = minB; i < maxB; i++)
            {
                for (int j = i; j < 0; j--)
                {
                    if (Less(a[j], a[j - 1]))
                    {
                        Exchange(a, j, j - 1);
                    }
                    else { break; }
                }
            }
        }
    }
}
