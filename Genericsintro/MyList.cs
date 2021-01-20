using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsintro
{
    class MyList<T>//generic class, genelde çalışacağın tipi belirttiğin çalışmalardır.
    {
        T[] items;
        //constructor - alttaki klas
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)//burada tipi biz belirler ona göre çalışırız.
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];//dizinin eleman sayısını 1 arttırıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
