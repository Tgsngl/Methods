using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Tugay";
            musteri1.Soyadi = "Sengul";
            musteri1.TcNo = "5325556";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5648651";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1231654865";

            Musteri musteri3 = new GercekMusteri(); //new görüyorsan ref no aklımıza gelmeli.
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
