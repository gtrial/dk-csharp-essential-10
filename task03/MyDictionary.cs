using System.Linq;

namespace task03
{
    public class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] _keys;
        private readonly TValue[] _values;

        public MyDictionary(TKey[] keys, TValue[] values)
        {
            _keys = keys;
            _values = values;
        }

        public void Add(TKey key, TValue value)
        {
            _keys.Append(key);
            _values.Append(value);
        }

        public TValue Index(TKey key)
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                if (_keys[i].Equals(key))
                {
                    return _values[i];
                }
            }

            return (TValue) new object();
        }

        public int Length()
        {
            return _keys.Length;
        }
    }
}