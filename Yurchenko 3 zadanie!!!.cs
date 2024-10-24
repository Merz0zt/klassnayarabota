namespace ConsoleApp20
{
    
    using System;
    using System.Collections.Generic;

    namespace Kata
    {
        public class QueueWithTwoStacks
        {
            private Stack<int> _inputStack = new Stack<int>();
            private Stack<int> _outputStack = new Stack<int>();

            public void Enqueue(int value)
            {
                _inputStack.Push(value);
            }

            public int Dequeue()
            {
                if (_outputStack.Count == 0)
                {
                    while (_inputStack.Count > 0)
                    {
                        _outputStack.Push(_inputStack.Pop());
                    }
                }

                return _outputStack.Pop();
            }
        }

    }
}
