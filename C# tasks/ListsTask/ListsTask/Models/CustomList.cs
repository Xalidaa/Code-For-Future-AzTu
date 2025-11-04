using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsTask
{
    class CustomList<T>
    {
        private T[] _items;
        public int Count { get; private set; }
        public int Capacity => _items.Length;


        public CustomList()
        {
            _items = Array.Empty<T>();
            Count = 0;
        }

        public CustomList(int capacity)
        {
           _items = new T[capacity];
            
        }

        public CustomList(params T[] items) 
        {
            _items = new T[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                _items[i] = items[i];
            }

            Count = items.Length;
        }

        public void Resize() 
        {
            int newCapacity;
            if (_items.Length == 0)
            {
                newCapacity = 4;
            }
            else
            {
                newCapacity = _items.Length * 2;
            }

            T[] newArr = new T[newCapacity];

            for(int i =0; i< Count; i++)
            {
                newArr[i] = _items[i];
            }
            _items = newArr;
        }


        public void Add(T item)
        {
            if(Count < Capacity)
            {
                _items[Count++] = item;
            }
            else
            {
                Resize();
                _items[Count++] = item;
            }
            Count++;

        }


        public int IndexOf(T item)
        {
            for(int i=0; i<Count;i++)
            {
                if(item.Equals(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }


        public void Remove(T item)
        {
           if(IndexOf(item) != -1)
            {
                for(int i =IndexOf(item); i<Count;i--)
                {

                }
            } 
        }

        public bool Contains(T item)
        {
            if(IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }

        public void Clear()
        {
            _items = new T[0];
            Count = 0;
        }

        public void PrintAll()
        {
            foreach(T item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
