using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {


        public  void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Musteri Silindi : " + musteri.MusteriAdi + musteri.Soyadi + " " +musteri.Parasi + " " + musteri.Yasi);
        }

        public  void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Musteri Eklendi : " + musteri.MusteriAdi + musteri.Soyadi + " " + musteri.Parasi + " " + musteri.Yasi+" "+musteri.Memleketi);

        }
        public  void Listele(Musteri[]  musteriler)
        {
            Console.WriteLine("Musteri Listesi");

            foreach (Musteri n in musteriler)
            {
                Console.WriteLine(n.MusteriAdi);
                Console.WriteLine(n.Soyadi);
                Console.WriteLine(n.Memleketi);
                Console.WriteLine(n.Yasi);
                Console.WriteLine(n.Parasi);
            }

        }
            


    }

}
