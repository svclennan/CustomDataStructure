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
        public int Capacity 
        { 
            get => capacity;
            set
            {
                capacity = value;
            }
        }
        private int count;
        public int Count 
        { 
            get => count;
        }
        public T this[int i]
        { 
            get => items[i];
            set => items[i] = value;
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
                T[] temp = items;
                items = new T[Capacity * 2];
                int index = 0;
                foreach (T item in temp)
                {
                    items[index] = item;
                    index++;
                }
                Capacity = capacity * 2;
            }
            items[count] = value;
            count++;
        }
    }
}