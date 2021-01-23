using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Musteri = new Dictionary<int, string>();
            
            Musteri.Add(13445, "Ali");
            Musteri.Add(15874, "Veli");
            Musteri.Add(11536, "Ayşe");
            Musteri.Add(17498, "Oya");
            Console.Write("Musteri No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Musteri[No]);
            }
            catch
            {
                Console.WriteLine("Müşteri kaydı bulunamadı.");
            }
        }
    }
}
