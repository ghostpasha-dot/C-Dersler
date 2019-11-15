using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Genel Kullanımlar
            string soyİsim =string.Empty;

            string kullanici1 = string.Empty;
            string kullanici2 = string.Empty;
            string kullanici3 = string.Empty;
            int not1, not2, not3 = 0;
            double ortalama = 0;

            Console.WriteLine("Lütfen Bilgileri Giriniz...");
            Console.Write("isim soyisim");
            soyİsim = Console.ReadLine();

            Console.Write("1.Not Değerini Giriniz=");
            kullanici1 = Console.ReadLine();
            Console.Write("2.Not Değerini Giriniz=");
            kullanici2 = Console.ReadLine();
            Console.Write("3.Not Değerini Giriniz=");
            kullanici3 = Console.ReadLine();

            not1 = int.Parse(kullanici1);
            not2 = int.Parse(kullanici2);
            not3 = int.Parse(kullanici3);

            ortalama =(not1+not2+not3)/3;
            Console.WriteLine(ortalama);

            if (ortalama>=50)
            {
                Console.WriteLine("Merhaba {0}",soyİsim);
                Console.WriteLine("Not ortalamanız {0} değeri ile geçtiniz",ortalama);
            }
            else
            {
                Console.WriteLine("Kaldınız..");
            }
            Console.ReadLine();
            #endregion

        }
    }
}
