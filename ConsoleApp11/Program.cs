using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanGelenDeger1, kullanicidanGelenDeger2, kullanicidanGelenSecim = string.Empty;

            int sayi1, sayi2, sonuc ;

            Console.WriteLine("Sayı 1 girin...");
            kullanicidanGelenDeger1 = Console.ReadLine();
            Console.WriteLine("Sayi 2 girin...");
            kullanicidanGelenDeger2 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İşlem Seçiniz...");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiminiz  :  ");
            kullanicidanGelenSecim = Console.ReadLine();

            sayi1 = int.Parse(kullanicidanGelenDeger1);
            sayi2 = int.Parse(kullanicidanGelenDeger2);

            switch (kullanicidanGelenSecim)
            {
                case "1":
                    sonuc = sayi1 + sayi2;
                    break;
                case "2":
                    sonuc = sayi1 - sayi2;
                    break;
                case "3":
                    sonuc = sayi1 * sayi2;
                    break;
                case "4":
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("1-4 arasında seçim yapınız...");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
