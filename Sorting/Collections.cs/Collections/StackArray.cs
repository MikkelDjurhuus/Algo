using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.cs
{
    public class StackArray<T>
    {
        private T[] stack;
        private int N = 0;

        public StackArray()
        {
            stack = new T[1];
        }

        public bool IsEmpty()
        {
            return N == 0;
        }
        
        public void Push(T item)
        {
            if (N == stack.Length)
            {
                Resize(stack.Length * 2);
            }
            stack[N++] = item;
        }

        public T Pop()
        {
            T item = stack[--N];
            stack[N] = default(T);
            if (N > 0 && N == stack.Length / 4)
            {
                Resize(stack.Length / 2);
            }
            return item;
        }

        private void Resize(int capacity)
        {
            T[] copy = new T[capacity];
            for (int i = 0; i < N; i++)
            {
                copy[i] = stack[i];
            }
            stack = copy;
        }
    }
}
