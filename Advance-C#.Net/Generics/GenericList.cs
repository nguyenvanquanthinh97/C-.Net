using System.Collections.Generic;

namespace Generics
{
    public class GenericList<T>
    {
        private readonly List<T> _list;

        public GenericList()
        {
            _list = new List<T>();
        }
        public void Add(T value)
        {
            _list.Add(value);
        }
    }
}