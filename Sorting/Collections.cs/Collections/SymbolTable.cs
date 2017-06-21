using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.cs.Collections
{
    public class SymbolTable
    {
        IComparable[] keys;
        IComparable[] values;

        int N;

        public SymbolTable()
        {
            keys = new IComparable[1];
            values = new IComparable[1];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Put(IComparable key, IComparable value)
        {
            ///st[N++] = new KeyValuePair<Tkey, TValue>(key, value);
        }

        public IComparable Get(IComparable key)
        {
            if (IsEmpty())
            {
                return null;
            }

            int i = Rank(key);
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                return values[i];
            }
            else
            {
                return null;
            }
        }

        private int Rank(IComparable key)
        {
            int lo = 0, hi = N - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                int cmp = key.CompareTo(keys[mid]);
                if (cmp < 0)
                {
                    hi = mid - 1;
                }
                else if (cmp > 0)
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return lo;
        }
    }
}
