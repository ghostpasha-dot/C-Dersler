using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region
            ////string[] ogrenciİslemListesi = new[] { "Ahmet ", "Mehmet", "Memet ", "Ali  ", "Yavuz" };


            ////foreach (string item in ogrenciİslemListesi)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////for (int i = 0; i <ogrenciİslemListesi.Length; i++)
            ////{
            ////    string gelenIsim = ogrenciİslemListesi[i];
            ////    Console.WriteLine(gelenIsim);
            ////}

            //Console.WriteLine("İütfen Oluşturmak İstediğiniz Dizinin Uzunluğunu Giriniz...");
            //string uygulama = Console.ReadLine();
            //int diziUzunluk = int.Parse(uygulama);
            //int[] uygulamaDizi = new int [diziUzunluk] ;
            //for (int uygulamaSayac = 0; uygulamaSayac < uygulamaDizi.Length; uygulamaSayac++)
            //{
            //    Console.WriteLine("{0}. index e denk gelen değeri giriniz",uygulamaSayac);

            //    uygulamaDizi[uygulamaSayac] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz...");
            //Console.WriteLine("Dizi içerisindeki değerler ve toplamı,ortalama değeri aşağıdaki gibidir...");
            //int uygulamaTopla=0, uygulamaOrtalama=0;
            //foreach (int item in uygulamaDizi)
            //{
            //    Console.WriteLine(item);
            //    uygulamaTopla = uygulamaTopla +item;

            //}

            //Console.WriteLine("+------------------------");

            //Console.WriteLine("Dizi içerisindeki eleman sayısı :{0}",uygulamaDizi.Length);
            //uygulamaOrtalama = uygulamaTopla / uygulamaDizi.Length;
            //Console.WriteLine("Ortalama:{0}",uygulamaOrtalama);


            //#endregion


            #region 
            Random rnd = new Random();
            int[] uygulamaDizisi = new int[20];
            for (int uygulamaSayac = 0; uygulamaSayac < uygulamaDizisi.Length; uygulamaSayac++)
            {
                uygulamaDizisi[uygulamaSayac] = rnd.Next(1,20);
            }
            int uygulamaBul = 0;
            foreach (int item in uygulamaDizisi)
            {
                Console.WriteLine(item);
                if (item == 4)

                    uygulamaBul++;
                
            }
            Console.WriteLine("Dizi içindeki 4 değeri {0} adettir...",uygulamaBul);
            Console.ReadKey();
             #endregion
        }
    }
}
