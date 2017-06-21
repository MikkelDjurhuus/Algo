using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sorting
{
    public class Selection : SortHelperfunctions
    {
        public static void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i+1; j < N; j++)
                {
                    if (Less(a[j], a[min]))
                    {
                        min = j;
                    }
                }
                Exchange(a, i, min);
            }
        }
    }
}
