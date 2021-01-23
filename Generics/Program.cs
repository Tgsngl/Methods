using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("İzmir");
            sehirler.Add("Muğla");
            sehirler.Add("Aydın");
            Console.WriteLine(sehirler.Count);

            
            //sehirler.Add("İstanbul");
            MyList<string> sehirler2 = new MyList<string>(); //burası string oyüzden alt satırda Add() içine  yazı yazdık. int yapsaydık Add() içine sayı yazacaktık.
            
            sehirler2.Add("Erzurum");
            sehirler2.Add("Antalya");
            sehirler2.Add("Kars");
            Console.WriteLine(sehirler2.Count);



        }
    }

    class MyList<T>//generic class. Type kullanırken hangi tiper verirsek ona dönüşüyor.
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for(int i=0; i<_tempArray.Length; i++)
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
