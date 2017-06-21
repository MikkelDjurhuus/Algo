using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace Collections.cs
{
    public class UnorderedMaxPQ<IComparable> : SortHelperfunctions
    {
        protected IComparable[] pq;
        protected int N;

        public UnorderedMaxPQ(int capacity)
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

        public virtual IComparable DelMax()
        {
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                if (Less(max, i))
                {
                    max = i;
                }
            }
            Exchange(pq, max, N - 1);
            return pq[--N];

        }


    }
}
