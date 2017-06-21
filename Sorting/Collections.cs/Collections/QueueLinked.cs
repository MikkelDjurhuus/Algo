using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.cs
{
    public class QueueLinked<T>
    {
        private Node<T> first, last = null;

        private class Node<T>
        {
            public T item;
            public Node<T> next;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Enqueue(T item)
        {
            Node<T> oldlast = last;
            last = new Node<T>();
            last.item = item;
            last.next = null;
            if (IsEmpty())
            {
                first = last;
            }
            else
            {
                oldlast.next = last;
            }
        }

        public T Dequeue()
        {
            T item = first.item;
            first = first.next;
            if (IsEmpty())
            {
                last = null;
            }
            return item;
        }
    }
}
