using System;
using System.Collections.Generic;
using System.Text;

namespace WorkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<int, string> city = new MyDictionary<int, string>();
            city.Add(34, "İstanbul");
            city.Add(07, "Antalya");
            city.Add(48, "Muğla");
            Console.WriteLine("*****Toplam Şehir Sayısı*****");
            Console.WriteLine(city.Count);
            Console.WriteLine("----Plaka Numaraları----");
            foreach (var kod in city.Keys)
            {
                
                Console.WriteLine(kod);
            }
            Console.WriteLine("----Şehirler----");
            foreach (var sehir in city.Values)
            {
                
                Console.WriteLine(sehir);
            }



        }
    }
}
