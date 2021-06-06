namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(){}
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue()
        {
            return _value != null;
        }

        public T GetValueOrDefault()
        {
            return _value != null ? (T)_value : default(T);
        }
    }
}