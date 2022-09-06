using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> LinkedStack = new LinkedStack<int>();

            ArrayStack<int> ArrayStack = new ArrayStack<int>(5);

            ArrayStack.Push(10);
            ArrayStack.Push(30);
            ArrayStack.Push(80);


            int Popped = ArrayStack.Pop();

            ArrayStack.Push(100);
            //ArrayStack.Pop();
            ;
        }
    }
}
