using System.Collections.Generic;
using System.Linq;

namespace task02
{
    public class MyList<T>
    {
        private readonly T[] _array;
        private IEnumerable<T> _enumerable;

        public MyList(T[] array)
        {
            _array = array;
            Length = _array.Length;
        }

        public void Add(T input)
        {
            _enumerable = _array.Append(input);
        }

        public T Index(int index)
        {
            return _array[index];
        }

        public int Length { get; }
    }
}