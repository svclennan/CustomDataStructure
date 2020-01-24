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
        public int Capacity { get => capacity; set => capacity = value; }
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
        public bool Remove(T value)
        {
            bool first = true;
            bool output = false;
            T[] temporary = new T[Capacity];
            int index = 0;
            foreach (T item in items)
            {
                if (item != null)
                {
                    if (item.Equals(value) && first)
                    {
                        count--;
                        first = false;
                        output = true;
                        continue;
                    }
                    temporary[index] = item;
                    index++;
                }
            }
            items = new T[Capacity];
            items = temporary;
            return output;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i]);
            }
            return sb.ToString();
        }
        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < a.Count; i++)
            {
                newList.Add(a[i]);
            }
            for (int i = 0; i < b.Count; i++)
            {
                newList.Add(b[i]);
            }
            return newList;
        }
        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> newList = a;
            for (int i = 0; i < b.Count; i++)
            {
                newList.Remove(b[i]);
            }

            return newList;
        }
        public CustomList<T> Zip(CustomList<T> b)
        {
            CustomList<T> zipped = new CustomList<T>();
            int indexA = 0;
            int indexB = 0;
            int total = Count + b.Count;
            while (total > 0)
            {
                if (indexA < Count)
                {
                    zipped.Add(items[indexA]);
                    indexA++;
                    total--;
                }
                if (indexB < b.Count)
                {
                    zipped.Add(b[indexB]);
                    indexB++;
                    total--;
                }
            }
            return zipped;
        }
    }
}