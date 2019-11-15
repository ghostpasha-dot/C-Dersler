using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Merhaba Do While");
            } while (1 == 2);
            #region Ödev 1
            string id = string.Empty;
            string sifre = string.Empty;
            int sayac = 0;
            do
            {
                if (sayac > 0)
                    Console.WriteLine("ID veya Şifre Hatalı...");
                Console.WriteLine("İD giriniz...");
                id = Console.ReadLine();

                Console.WriteLine("Şifre giriniz...");
                sifre = Console.ReadLine();

                sayac++;
            } while (id.ToLower() != "demo" || sifre.ToLower() != "demo");

            Console.WriteLine("Başarılı giriş... ");

            #endregion
            #region Ödev 2
            int odev2Tahmin = 0;
            int odev2UretilenSayi = 0;
            int odev2Sayac = 0;

            Console.WriteLine("Tahmin Oyunu İçin En yüksek Değeri Giriniz...");
            int odev2KullaniciMaxValue = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            rnd.Next(1,odev2KullaniciMaxValue);

            do
            {
                odev2Sayac++;
                Console.WriteLine("{0} Hakkınız Üretilen Sayıyı Tahmin Ediniz...", odev2Sayac);
                odev2Tahmin = int.Parse(Console.ReadLine()) ;

            } while (odev2Tahmin!=odev2UretilenSayi);
            Console.WriteLine("{0} . kere denediniz Sayıyı tahmin ettiniz", odev2Sayac);
            Console.ReadKey();
            #endregion

        }
    }
}
