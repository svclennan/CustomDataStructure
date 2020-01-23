using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] items;
        private int capacity;
        private int count;
        public int Capacity {  get => capacity; set => capacity = value; }
        public int Count { get => count; }
        public T this[int i] { get => items[i]; set => items[i] = value; }

        public CustomList()
        {
            items = new T[4];
            Capacity = 4;
            count = 0;
        }

        public void Add(T value)
        {
            if (count == capacity)
            {
                Capacity = capacity * 2;
                CopyList();
            }
            items[count] = value;
            count++;
        }
        public void CopyList()
        {
            T[] temporary = new T[Capacity];
            int index = 0;
            foreach (T item in items)
            {
                temporary[index] = item;
                index++;
            }
            items = new T[Capacity];
            items = temporary;
        }
        public void Remove(T value)
        {
            bool first = true;
            T[] temporary = new T[Capacity];
            int index = 0;
            foreach (T item in items)
            {
                if (item.Equals(value))
                {
                    if (first)
                    {
                        count--;
                        first = false;
                        continue;
                    }
                }
                temporary[index] = item;
                index++;
            }
            items = new T[Capacity];
            items = temporary;
        }
    }
}