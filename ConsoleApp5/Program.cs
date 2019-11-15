using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanicidanGelenDeger = string.Empty;

            Console.Write("Mesaj 1");
            Console.WriteLine("Mesaj 2");

            Console.Write("Lütfen Adınızı Giriniz:");
            kullanicidanGelenDeger = Console.ReadLine();

            string mesaj = "Girmiş olduğunuz isim değeri  " + kullanicidanGelenDeger;
            Console.WriteLine(mesaj);
            Console.Clear();


            mesaj = "";
            mesaj=string.Format("Girmiş olduğunuz isim değeri {0}",kullanicidanGelenDeger);

            Console.Clear();
            Console.WriteLine("Girmiş olduğunuz isim değeri {0}", kullanicidanGelenDeger);

            Console.Clear();
            Console.WriteLine("Lütfen 1-10 arasında bir değer giriniz");
            string gelenDeger = Console.ReadLine();
            
            int sayi1 = int.Parse(gelenDeger);
            int sayi2 = Convert.ToInt32(gelenDeger);
            int toplam = sayi1 + 15;

            Console.WriteLine("Toplam değer:{0}", toplam);

            Console.ReadLine();
        }
    }
}
