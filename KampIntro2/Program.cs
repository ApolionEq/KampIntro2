using System;

namespace KampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety -tip güvenliği
            //değer tutucu,alias

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu ");
            }
           
            if (sistemeGirisYapmısMı==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
