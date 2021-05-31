using System;
using System.Collections.Generic;

namespace Exercise_DesignAStack
{
    public class Stack
    {
        private readonly List<object> _items; 
        public Stack()
        {
            _items = new List<object>();
        }

        public object this[int idx]
        {
            get { return _items[idx]; }
            set
            {
                if (idx >= _items.Count)
                {
                    throw new InvalidOperationException("Cannot access element of null");
                }

                _items[idx] = value;
            }
        }

        public void Push(object value)
        {
            if (value == null)
            {
                throw new InvalidOperationException("Can not add null to Stack");
            }
            _items.Add(value);
        }

        public object Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var lastIdx = _items.Count - 1;
            var item = _items[lastIdx];
            _items.RemoveAt(lastIdx);
            return item;
        }

        public void Clear()
        {
            _items.Clear();
        }

        public void ToString()
        {
            foreach (var item in _items)
            {
                Console.Write("{0}\t",item);
            }

            Console.WriteLine();
        }
    }
}