using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety -tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias (kategoriEtiketi)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }


            Console.WriteLine(kategoriEtiketi);




        }
    }
}
