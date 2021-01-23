using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> plaka1 = new MyDictionary<int>();
            plaka1.Add(1);
            plaka1.Add(2);
           
            Console.WriteLine(plaka1.Count);

            MyDictionary<int> plaka2 = new MyDictionary<int>();
            plaka2.Add(6);
            plaka2.Add(7);
            plaka2.Add(8);
            plaka2.Add(9);
            plaka2.Add(10);
            plaka2.Add(11);
            Console.WriteLine(plaka2.Count);

        }

        class MyDictionary<T> //Generic class
        {
            T[] _array;
            T[] _tempArray;

            public MyDictionary()
            {
                _array = new T[0];

            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;

            }
            public int Count
            {
                get { return _array.Length; }
            }


        }
    }
}