using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable<T> where T : IComparable
    {
        T[] items;
        private int capacity;
        private int count;
        public int Capacity { get => capacity; set => capacity = value; }
        public int Count { get => count; }
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[i];
            }
            set
            {
                if (i < 0 || i >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[i] = value;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

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

        public void SelectionSort()
        {
            T minValue;
            int minIndex;
            for (int j = 0; j < count-1; j++)
            {
                minValue = items[j];
                minIndex = j;
                for (int i = j; i < count; i++)
                {
                    if (items[i].CompareTo(minValue) < 0)
                    {
                        minValue = items[i];
                        minIndex = i;
                    }
                }
                items[minIndex] = items[j];
                items[j] = minValue;
            } 
        }

        public void InsertionSort()
        {
            for (int i = 1; i < count; i++)
            {
                T key = items[i];
                int j = i - 1;
                while (j >= 0 && items[j].CompareTo(key) > 0)
                {
                    items[j + 1] = items[j];
                    j -= 1;
                }
                items[j + 1] = key;
            }
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].CompareTo(value) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            items = new T[4];
            capacity = 4;
            count = 0;
        }

        public void Reverse()
        {
            CustomList<T> temporary = new CustomList<T>();
            for (int i = count; i > 0; i--)
            {
                temporary.Add(items[i-1]);
            }
            int index = 0;
            foreach (T item in temporary)
            {
                items[index] = item;
                index++;
            }
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T value)
        {
            if (count == capacity)
            {
                Capacity = capacity * 2;
            }
            T[] newList = new T[count + 1];
            for (int i = 0; i < index; i++)
            {
                newList[i] = items[i];
            }
            newList[index] = value;
            count++;
            for (int i = index + 1; i < count; i++)
            {
                newList[i] = items[i-1];
            }
            items = new T[Capacity];
            items = newList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
    }
}