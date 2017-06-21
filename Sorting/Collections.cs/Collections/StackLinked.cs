using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.cs
{
    public class StackLinked<T>
    {
        private Node<T> first = null;

        private class Node<T>
        {
            public T item;
            public Node<T> next;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void Push(T item)
        {
            Node<T> oldfirst = first;
            first = new Node<T>();
            first.item = item;
            first.next = oldfirst;
        }

        public T Pop()
        {
            T item = first.item;
            first = first.next;
            return item;
        }
    }
}
