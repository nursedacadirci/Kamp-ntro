using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary1
{
    class MyList<T>
    {
        T[] items;

        //constructor
        //ctor tab tab
        public MyList()
        {
            items = new T[0];
        }


        public void Add(T item)
        {
            //önceki eklenen elemanları tutar
            T[] tempArray = items;


            //eleman sayısı bir arttırılır
            items = new T[items.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;





        }
    }
}
