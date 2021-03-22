using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Temel Programlama Kursu";
            string kurs3 = "Java Kursu";



            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Temel Programlama Kursu", "Java Kursu" ,"C#"};

            for (int i = 0; i <kurslar.Length; i++)//eğer iki artırmak istersek i=i+2 veya i=+2 şeklinde yazarız.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)//dizi temelli yapıları tek tek dönmeye yarar.//string (alias) in diziİsmi
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu -footer");
        }
    }
}
