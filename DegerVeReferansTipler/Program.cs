using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;                        //    sayi1=10 sayi1 in değeri 10 dur
            int sayi2 = 30;                        //    sayi2=30 sayi2 nin değeri 30 dur
            sayi1 = sayi2;                         //    sayi1=sayi2 demek sayi1 i sayi2 ye eşitlemek demektir yani sayi1=30 oldu demektir
            sayi2 = 65;                            //    sayi2=65 olunca sayi1 yine 30 kalır çünkü eşitleme yapmadık sadece sayi2 ye yeni değer verdik 
            //sayi1 ??                             //
            Console.WriteLine(sayi1);//A:30 +R:65- //

            int[] sayilar1 = new int[] { 10, 20, 30 };    // stack:sayilar1/(101)  => heap:[10,20,30]/(101=adresi bu)
            int[] sayilar2 = new int[] { 100, 200, 300 }; // stack:sayilar2/102    => heap:[100,200,300]/102
            sayilar1 = sayilar2;                          // stack sayilar1=sayilar2 => sayilar1(102)=(102)sayilar2 artık say,lar1 in adresi 102.// 101anlamsız olur ve  garbage colectora gider yani çöp kutusu
            sayilar2[0] = 999;                            // ve bu durumda sayilar1 ile sayilar2 =[100,200,300] olur.
            //sayilar1[0]                                 // eğer sayilar1=sayilar2 yaparsak ve sayilar1[0] ı sorarsak en sonda örnekte gösterildiği gibi 999 olur.
            //A:100-  R:999+                                                                          

            //int,decimal,float,double,bool(0 ile 1i tutar)=DEĞER TİP =>Bunlar sadece sayısal veri tutanlardır.
            //array,class,interface=REFERANS TİP =>Bunların int string felan olması önemli değil.
        }
    }
}
