using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };


            Urun urun1 = new Urun();//Bir class olduğu için newlemen lazım.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kayısı";
            urun2.Fiyati = 44;
            urun2.Aciklama = "Malatya Malatya bulunmaz eşin Kayısısı";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("************************");

            }

            Console.WriteLine("------------Metotlar------------------");

            //instance-örnek
            //encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,32);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 22,9);
            sepetManager.Ekle2("Kayısı", "Yeşil Kayısı", 32,5);


        }
    }
}


//DO NOT REPEAT YOURSELF-DRY- Clean Code - Best Practice