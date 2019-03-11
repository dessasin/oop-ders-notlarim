using System;

namespace ders3
{
    class MainClass
    {
        public static void Main(string[] args)
            // /* */ ARASINDA KALAN KISIMLARI /* */ İFADELERİNİ SİLEREK ÇALIŞTIRABİLİRSİNİZ
        {

            /*
            int sayi = 0; // stack bölgesinde yer alan değişkendir
            const int sayi2 = 0;// sabit ram bölgesinde yer alır ayrıca sabit değişken tanımlama biçimidir 

            {
                int sayi3 = 12; // ayrılmış blok
            }

           */



            /*
            byte a = 25;
            int b = a;
            Console.WriteLine(b);
            */

            /*
            int a = 258; // zorla dönüştürme 
            byte b = (byte)a;
            Console.WriteLine(b); // çıktısı "2" dir.
            */

            /*
            int a = 258; 
            checked                // taşma kontrolcüsü
            {
                byte b = (byte)a;
                Console.WriteLine(b);
            } 
            */

            /*
            int a = 258;
            unchecked                // taşmayı göz ardı edilmesi durumudur            
            {
                byte b = (byte)a;
                Console.WriteLine(b);
            }
            */


            // Tür Dönüşümleri

            /*
            int sayi1 = 12;
            sayi1 = Convert.ToByte(sayi1);
            */


            // Aritmetik operatörler

            int sayi = 3;
            double sayi2 = 215;
            double bol = 3;
            double bolum;
            float deg = 25;

            sayi = 123 + 123; // toplama
            Console.WriteLine(sayi);

            sayi = 12312 - 123; // çıkarma
            Console.WriteLine(sayi);

            sayi = 123 * 123; // çarpma
            Console.WriteLine(sayi);

            bolum = sayi2 / bol; // bölme
            Console.WriteLine(bolum);

            deg=deg/2; // bölme
            Console.WriteLine(deg);



            Console.Read();
        }
    }
}
