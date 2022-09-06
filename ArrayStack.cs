using System;
namespace Stacks
{
    public class ArrayStack<T>
    {
        public int Count { get; private set; }
        private T[] data;
        private int capacity;

        public ArrayStack(int Capacity)
        {
            Count = 0;
            data = new T[Capacity];
            capacity = Capacity;
        }

        public void Push(T value)
        {
            if (Count == capacity)
            {
                Resize();

                data[Count] = value;
            }

            else
            {
                data[Count] = value;
            }

            Count++;
        }

        public T Pop()
        {
            if(Count == 0)
            {
                throw new Exception("Stack is empty");
            }
            Count--;

            return data[Count];

        }

        public void Resize()
        {

            T[] newArray = new T[data.Length * 2];

            for (int i = 0; i < newArray.Length; i++)
            {

                newArray[i] = data[i];

            }


            data = newArray;
        }
    }
}
