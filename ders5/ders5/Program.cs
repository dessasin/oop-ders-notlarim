using System;

namespace ders5
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // döngüler
            /*
            int basla = 263;
            int bitis = 34847;
            int topla = 0;
            int tektop = 0;
            int cifttop = 0;
            for (int i = basla; i < bitis; i++)
            {
                if (i % 2 ==0)
                {
                    cifttop += i;

                }else if (i % 2!=0)
                {
                    tektop += i;
                }
            }
            Console.WriteLine("Çift toplamlar: " + cifttop + " " + "Tek toplamlar:  " + tektop);
            Console.WriteLine("Farklar:" + (cifttop - tektop));

            */

            /*
            int basla = 263;
            int bitis = 34847;
            int topla = 0;
            int tekbol = 0;
            int ciftbol = 0;
            for (int i = basla; i < bitis; i++)
            {
                if (i % 3 == 0 && i % 7 == 0&&i%24!=0)
                {
                    ciftbol += 1;
                }
                if (i % 2 == 0 && i % 5 == 0 && i % 15 != 0)
                {
                    tekbol += 1;
                }
            }
            Console.WriteLine("İlk Şart sağlayanlar:  " + ciftbol);
            Console.WriteLine("İkinci Şart sağlayanlar:  " + tekbol);
            if (ciftbol<tekbol)
            {
                Console.WriteLine("İkinci Şart sağlayanlar Daha fazla  ");

            }
            Console.WriteLine("Farklar: "+ (tekbol-ciftbol));
            */

            // iç içe döngüler


            /*
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j <=3; j++)
                {
                    for (int k = 4; k > 2; k--)
                    {
                        Console.WriteLine("i: {0} j: {1} k: {2}",i,j,k);
                    }
                }
            }*/


            // asal sayı
            /*
            int basla = 263;
            int bitis = 34847;
            bool asalmi = true;

            for (int i = basla; i < bitis; i++)
            {
                asalmi = true;
                for (int k = 2; k < i; k++)
                {
                    if (i%k==0)
                    {
                        asalmi = false;
                    }
                }
                if (asalmi==true)
                {
                    Console.WriteLine("Asalsayi" + i);
                }

            }
            */

            // while döngüsü

            /* bool kosul = true;
             int i = 0;
             while (kosul)
             {
                 if (i>5)
                 {
                     kosul =false;
                 }
                 i++;
                 Console.WriteLine("Dön" + i);
             }*/

            /*
           int toplam = 0;
           int sayilar = 0;
           int i = 0;
           while (toplam < 5000)
           {
               i++;
               toplam += i;

           }
           Console.WriteLine(toplam);

           */

            /*
            int sayac = 0;
            int ciftsay = 0;
            int teksay = 0;      sayılar arasındaki tek sayılar ile çift sayıların farklarının 20000 den küçük olduğu döngü
            int fark = 0;
            while (fark <20000)
            {
                sayac++;
                fark -= sayac;
                if (sayac%2==0)
                {
                    ciftsay += sayac;
                }
                else
                {
                    teksay += sayac;
                }
                fark = Math.Abs(teksay - ciftsay);
            }
            Console.WriteLine(sayac);
            Console.WriteLine("fark: " + fark);

    */
            Console.Read();
        }
    }
}
