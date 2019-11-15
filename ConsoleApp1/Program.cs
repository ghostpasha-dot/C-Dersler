using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            isim = "serhat";
            Console.Write("Kullanıcı Adı:");
            Console.WriteLine(isim);
            

            int i = 4;
            int y = i;
            Console.Write("i nin değeri:");
            Console.WriteLine(i); 
            Console.Write("y nin değeri:");
            Console.WriteLine(y);
            y = 10;
            Console.Write("i nin değeri:");
            Console.WriteLine(i);
            Console.Write("y nin değeri:");
            Console.WriteLine(y);


            int sayi1 = 0;
            sayi1 = int.MinValue;
            Console.WriteLine("En Düşük Değer:");
            Console.WriteLine(sayi1);
            sayi1=int.MaxValue;
            Console.WriteLine("En Büyük Değer:"); 
            Console.WriteLine(sayi1);


            double sayi2 = double.MinValue;
            {
                int toplam = 30;
                Console.WriteLine(toplam);
                toplam = 40;
                sayi2 = 100;
            }
            Console.WriteLine(sayi2);
            Console.ReadKey();
        }
    }
}
