using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        
        static void Main(string[] args)
        {
         
            string kullanicidanGelenDeger1, kullanicidanGelenDeger2 , kullanicidanGelenSecim =string.Empty ;
           
            int sayi1, sayi2,sonuc=0;

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

            if (kullanicidanGelenSecim=="1")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (kullanicidanGelenSecim=="2")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (kullanicidanGelenSecim=="3")
            {
                sonuc = sayi1 * sayi2;
            }

            else if(kullanicidanGelenSecim=="4")
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Aralık dışında değer girişi yaptınız");
            }
            if (sonuc!=0)
            {
                Console.WriteLine("İşleminizin sonucu {0} ",sonuc);  
            }
            
            Console.ReadKey();
            
        }
    }
}
