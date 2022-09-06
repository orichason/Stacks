using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks
{
    public class LinkedStack<T>
    {
        public int Count { get; private set; }
        private LinkedList<T> data;

        public LinkedStack()
        {
            Count = 0;
            data = new LinkedList<T>();
        }

        public void Push(T value)
        {
            data.AddLast(value);
        }

        public T Pop()
        {
            data.RemoveLast();

            return data.Last();
        }

        public T Peek()
        {
            return data.Last();
        }
    }
}
