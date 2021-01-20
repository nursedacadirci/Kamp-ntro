using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsInstro
{
    //item=eleman
    class MyList<T>  // mylistte T ile çalışıcam (tip)
    {
        T[] items;
        //ctor tab tab-constructor
              
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //T olarak ne verirsem istediğim elemanın türü de o olsun
        {
            //temparray geçici dizi
            T[] tempArray = items; //yeni dizi tanımlandığında önceki elemanın kaybolmaması için yazılır.
            items = new T[items.Length+1];//dizinin eleman sayısını 1 arttır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//eski diziyi geri almak için yazılır.
            }

            items[items.Length - 1] = item; //itemsın son elemanının uzunluğunun -1. değerini verir.0 dan başladığı için 5. değeri verir.
             
        }
    }
}
