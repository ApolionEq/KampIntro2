using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yasi = 36;

            Kurs kurs1 = new Kurs();//Classları tanımlarken her zaman new lemen lazım.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 73;

            Kurs kurs2 = new Kurs();//Classları tanımlarken her zaman new lemen lazım.
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOranı = 65;

            Kurs kurs3 = new Kurs();//Classları tanımlarken her zaman new lemen lazım.
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 84;

            //Console.WriteLine(kurs1.KursAdi +" : "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {
                // Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);

            }

            


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }



    }
}
