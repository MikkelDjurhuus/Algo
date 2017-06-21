using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace Collections.cs
{
    public class BinaryHeapPQ
    {
        protected IComparable[] pq;
        protected int N;

        public BinaryHeapPQ(int capacity)
        {
            pq = new IComparable[capacity];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Insert(IComparable x)
        {
            pq[N++] = x;
        }

        public IComparable DelMax()
        {
            IComparable max = pq[1];
            Exchange(1, N--);
            Sink(1);
            pq[N + 1] = null;
            return max;
        }

        private void Sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && Less(j, j + 1))
                {
                    j++;
                }
                if (!Less(k, j)) { break; }
                Exchange(k, j);
                k = j;
            }
        }

        private void Swim(int k)
        {
            while (k > 1 && Less(k / 2, k))
            {
                Exchange(k, k / 2);
                k = k / 2;
            }
        }

        private bool Less(int i, int j)
        {
            return pq[i].CompareTo(pq[j]) < 0;
        }

        private void Exchange(int i, int j)
        {
            IComparable t = pq[i];
            pq[i] = pq[j];
            pq[j] = t;
        }
    }
}
