using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.cs
{
    class QueueArray<T>
    {
        private T[] queue;
        private int head, tail, count, capacity;

        public QueueArray()
        {
            capacity = 1;
            count = 0;
            tail = capacity - 1;
            head = 0;
            queue = new T[capacity];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Enqueue(T item)
        {
            if (count == queue.Length)
            {
                Resize(queue.Length * 2);
            }
            count++;
            queue[tail++ % capacity] = item;
        }

        public T Dequeue()
        {
            count--;
            T item = queue[head++ % capacity];
            queue[head] = default(T);
            if (capacity > 0 && capacity == queue.Length / 4)
            {
                Resize(queue.Length / 2);
            }
            return item;
        }

        private void Resize(int capacity)
        {
            T[] copy = new T[capacity];
            int current = head;
            for (int i = 0; i < count; i++)
            {
                copy[i] = queue[i];
                current = current++ % count;
            }
            queue = copy;
            head = 0;
            tail = count - 1;
            this.capacity = capacity;
        }
    }
}
