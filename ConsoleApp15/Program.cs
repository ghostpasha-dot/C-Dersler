using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new[] {"Ali ","Ahmet","Mehmet","Fuat" };
            //foreach (string item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            //int sayav = 1;
            //while (sayav<=10)
            //{
            //    Console.WriteLine(sayav);
            //    sayav++;
            //}

            //Console.WriteLine("Değer Giriniz...");
            //string gelenSayi = Console.ReadLine();
            //int sayac = int.Parse(gelenSayi);

            //while (sayac!=-1)
            //{
            //    Console.WriteLine(sayac);
            //    sayac = sayac - 1;
            //}
            //Console.WriteLine("Örnek 1 İşlemi Bitti... ");


            //Console.WriteLine("Değer Giriniz...");
            //Console.WriteLine("-1 işlemi Durdurur...");

            //int kullanım = 0;

            //while (true)
            //{
            //    string kullanim2 = Console.ReadLine();
            //    int kullanım2Int = int.Parse(kullanim2);
            //    if (kullanım2Int<0)

            //        break;

            //    else

            //        kullanım = kullanım + kullanım2Int; 

            //}
            //Console.WriteLine("{0}",kullanım);

            int sistemUretSayi=0;
            int tahminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10);
           
            while (true)
            {
                Console.WriteLine("{0} .Deneme-Lütfen tahmin ediniz:", tahminAdet);
                string rndKullaniciGelen = Console.ReadLine();

                int rndKullaniciInt = int.Parse(rndKullaniciGelen);
                //if (int.Parse(rndKullaniciGelen) == sistemUretSayi)  
                if (rndKullaniciInt == sistemUretSayi)
                {
                    tahminAdet++;
                    Console.WriteLine("{0} .Denemeniz...Tebrikler...",tahminAdet);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0} .Denemeniz...Tekrar Deneyin...",tahminAdet);
                    tahminAdet++;
                }
            }
            Console.ReadKey();
        }
    }
}
