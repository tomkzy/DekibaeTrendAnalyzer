using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekibaeTrendAnalyzer.Models
{
    public struct Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min must be less than or equal to Max.");

            Min = min;
            Max = max;
        }

        public bool Contains(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public bool IsEmpty => Min.CompareTo(Max) > 0;

        public override string ToString() => $"[{Min} ～ {Max}]";
    }
}
