using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections.cs
{
    public class Bag<T>
    {
        private T[] bag;
        private int N = 0;

        public Bag()
        {
            bag = new T[1];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public void Add(T item)
        {
            if (N == bag.Length)
            {
                Resize(bag.Length * 2);
            }
            bag[N++] = item;
        }

        private void Resize(int capacity)
        {
            T[] copy = new T[capacity];
            for (int i = 0; i < N; i++)
            {
                copy[i] = bag[i];
            }
            bag = copy;
        }

        public Iterator<T> GetIterator()
        {
            return new Iterator<T>(N, bag);
        }

        public class Iterator<T>
        {
            private T[] bag;
            private int i;

            public Iterator(int N, T[] bag)
            {
                i = N;
            }

            public bool HasNext()
            {
                return i > 0;
            }

            public T Next()
            {
                return bag[i--];
            }
        }
    }
}
