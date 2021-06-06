using System;

namespace Generics
{
    // where T : IComparable  ** implement interface
    // where T : Product ** implement class or subclass
    // where T : struct ** implement value type
    // where T : class ** implement reference type
    // where T : new() ** implement default constructor
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int val1, int val2)
        {
            return val1 > val2 ? val1 : val2;
        }
        public void DoSomething()
        {
            var obj = new T();
        }
        public T Max(T val1, T val2)
        {
            return val1.CompareTo(val2) > 0 ? val1 : val2;
        }
    }

    public class Utility
    {
        public T Max<T>(T val1, T val2) where T : IComparable
        {
            return val1.CompareTo(val2) > 0 ? val1 : val2;
        }
    }
}