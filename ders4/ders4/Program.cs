using System;

namespace ders4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // mantıksal operatörler
            /*
            bool sonuc;
            sonuc = false || false;
            Console.WriteLine(sonuc);
            */

            // Bitsel operatörler

            /*
             byte b1 = 255;
            byte b2 = 5;

            byte sonuc = (byte)(b1 | b2);
            Console.WriteLine(sonuc);
            sonuc = (byte)(b1 & b2);
            Console.WriteLine(sonuc);
            sonuc = (byte)(b1 ^ b2);
            Console.WriteLine(sonuc);
            sonuc = (byte)(b1 << 4);
            Console.WriteLine(sonuc);
            sonuc = (byte)(b1 >> 4);
            Console.WriteLine(sonuc);
            */

            // matematiksel fonksiyonlar

            /*
            double sayi = -3.5;
            Console.WriteLine(Math.Ceiling(sayi));

            sayi = 3.5;
            Console.WriteLine(Math.Floor(sayi));

            Console.WriteLine(Math.Round(sayi));


            Console.WriteLine(Math.Pow(sayi,4));
            Console.WriteLine(Math.Pow(sayi, 0.5));

            Console.WriteLine(Math.Sqrt(sayi));
            */


            // Karşılaştırma cümleleri if 

            //ikinci dereceden denklemin köklerini bulan program
            double a,b,c,delta,kok1,kok2;

            a = 1;
            b = 5;
            c = 6;
            delta = Math.Pow(b, 2) - (4 * (a * c));
            if (delta==0)
            {
               
                kok1 = (-b) / (2 * a);
                Console.WriteLine("Çakışık Kök:"+kok1);
            }
            else if(delta>0)
            {
                kok1 = (-b + Math.Sqrt(delta))/2*a;
                kok2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Kök 1= " + kok1);
                Console.WriteLine("Kök 2= " + kok2);
            }

            Console.Read();






        }
    }
}
