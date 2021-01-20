using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] musteriler = new string[] {  };

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi= "Mucahit";
            musteri1.Soyadi= "Uzak";
            musteri1.Parasi = 2000;
            musteri1.Yasi = 25;
            musteri1.Memleketi = "İstanbul";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Eren";
            musteri2.Soyadi = "Gözsüz";
            musteri2.Parasi = 5000;
            musteri2.Yasi = 19;
            musteri2.Memleketi = "Bitlis";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Rahman";
            musteri3.Soyadi = "Alim";
            musteri3.Parasi = 500;
            musteri3.Yasi = 55;
            musteri3.Memleketi = "Hakkari";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriAdi = "Enes";
            musteri4.Soyadi = "Kilic";
            musteri4.Parasi = 2845;
            musteri4.Yasi = 36;
            musteri4.Memleketi = "Ankara";
            Musteri[] musteriler1 = new Musteri[] { musteri1, musteri2,musteri4 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri3);
            musteriManager.Listele(musteriler1);
       

        }
    }
}
