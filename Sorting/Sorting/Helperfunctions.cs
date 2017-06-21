using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SortHelperfunctions
    {
        public static bool Less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public static bool Greater(IComparable v, IComparable w)
        {
            return v.CompareTo(w) > 0;
        }

        public static void Exchange<T>(T[] a, int i, int j)
        {
            T swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        public static void Shuffle(object[] a)
        {
            int N = a.Length;
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                int r = rnd.Next(0, i + 1);
                Exchange(a, i, r);
            }
        }

        public static bool IsSorted(IComparable[] a, int lo, int hi)
        {
            for (int i = lo; i <= hi; i++)
            {
                if (a[i].CompareTo(a[i+1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
