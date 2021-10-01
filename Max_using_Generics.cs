using System;
using System.Collections.Generic;
using System.Text;

namespace Day13Assigment
{
    public class Max_using_Generics<T> where T : IComparable
    {
        public T[] value;
        public Max_using_Generics(T[] value)
        {
            this.value = value;
        }
        public T[] sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is :"+max);
        }
    }
}
