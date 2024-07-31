using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AD01
{
    public class Range<T> where T : IComparable<T>
    {
       public T _min { get; private set; }
        public  T _max { get; private set; }

        public Range(T min, T max)
        {
            _min = min;
            _max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
        }

        public T Length()
        {
            return _max.CompareTo(_min) > 0 ? (dynamic)_max - (dynamic)_min : (dynamic)_min - (dynamic)_max;
        }
    }
}
