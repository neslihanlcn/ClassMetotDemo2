using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "selin";
            musteri1.Soyadi = "yıldız";
            musteri1.meslek = "öğretmen";
            musteri1.TelefonNumarasi = 123456789;
            musteri1.KimlikNumarasi = 111111111;


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "bahar";
            musteri2.Soyadi = "güler";
            musteri2.meslek = "pilot";
            musteri2.TelefonNumarasi = 4567633;
            musteri2.KimlikNumarasi = 22222222;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "demir";
            musteri3.Soyadi = "solmaz";
            musteri3.meslek = "esnaf";
            musteri3.TelefonNumarasi = 345322345;
            musteri3.KimlikNumarasi = 3333333;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "ozan";
            musteri4.Soyadi = "bulut";
            musteri4.meslek = "doktor";
            musteri4.TelefonNumarasi = 456743345;
            musteri4.KimlikNumarasi = 4444444;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.meslek);
                Console.WriteLine(musteri.TelefonNumarasi);
                Console.WriteLine("------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri3);
            musteriManager.Listele(musteri4);

;

        }
    }
}
