using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Generic_types_Collections.Models
{
    internal class CustomList<T>
    {
        private T[] _arr;
        private int capacity;
        int Count;
        public T this[int index]
        {
            get 
            { 
                return _arr[index]; 
            }
            set 
            {
                _arr[index] = value; 
            }
        }

        public int Capacity { get; set; }
        public CustomList()
        {
            int Count = 0;
            _arr = new T[2];
            capacity = 2;
        }

        public bool Remove(T value)
        {
            var numToRemove = value;
            _arr = _arr.Except(new T[] { value }).ToArray();
            return true;

        }



        public void Add(T value)
        {
            if (Count == capacity)
            {
                Resize();
            }
            _arr[Count] = value;
            Count++;

        }
        public void Resize()
        {
            T[] ResizedArr = new T[capacity * 2];
            for (int i = 0; i < capacity; i++)
            {
                ResizedArr[i] = _arr[i];
            }
            _arr = ResizedArr;
            capacity=capacity*2;
        }
        public bool Resize(T value)
        {
            if (true)
            {
                T[] ResizedArr = new T[capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    ResizedArr[i] = _arr[i];
                }
                _arr = ResizedArr;
                capacity = capacity * 2;
                return true;
            }
            else return false;
        }
        public void Clear()
        {
            Array.Resize(ref _arr, 0);
        }
        public bool Exist(T value)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
               if (_arr[i].Equals(value))
                {
                    return true;
                }

            }
            return false;

        }
        public bool Reverse()
        {
            T tmp;
            for (int i = 0; i < _arr.Length / 2; i++)
            {
                tmp = _arr[i];
                _arr[i] = _arr[_arr.Length - i - 1];
                _arr[_arr.Length - i - 1] = tmp;
            }return true;
        }
        public int IndexOf(T value)
        {
            int index = -1;

            for (int i = 0; i < Count; i++)
            {
                if (_arr[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        public int LastIndexOf(T value)
        {
            for (int i = 0; i <_arr.Length; i++)
            {
                if(_arr[i].Equals(value)) return i;
            }
            return -1;
        }

    }
}
