using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();

            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1-Değer Ekle");
                Console.WriteLine("2-Değer Listele");
                Console.WriteLine("3-Değer Ara");
                Console.WriteLine("4-Değer Düzenle");
                Console.WriteLine("5-Değer Sil");
                Console.WriteLine("6-Uygulama Çıkışı");
                Console.Write("Seçiniz:  ");
                kullaniciSecim= Console.ReadLine();
                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lütfen eklemek istediğiniz değeri giriniz:");
                        string kullaniciDeger = Console.ReadLine();
                        degerListesi.Add(kullaniciDeger);
                        Console.WriteLine("Değeriniz Başarılı Bir Şekilde Eklendi");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}.  Değer={1}",i,degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için basınız...");
                        Console.ReadLine(); 
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz...");
                        string kullaniciArananDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(kullaniciArananDeger);
                        if (kontrol)    
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciArananDeger);
                            string bulunanDeger  = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("Değeriniz Bulundu :İndex Sırası:{0} .Değer",bulunanIndex,bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız Değer Bulunamadı");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "4":
                        Console.WriteLine("Güncellemek İstediğiniz Değeri Girin: ");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();

                        Console.WriteLine("{0} değerini hangi değer ile güncelleştirmek istiyorsunuz",kullaniciDuzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();

                        if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Değeriniz Güncellendi...");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız Değer Liste İçerisinde Bulunamadı...");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "5":
                        Console.WriteLine("Tüm Değerleri Mi Silmek İstiyorsunuz (E/H)");
                        string kullaniciSilCevap = Console.ReadLine();
                        if (kullaniciSilCevap.ToUpper()=="E")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm Değerler Silindi...");
                        }
                        else
                        {
                            Console.WriteLine("Silmek İstediğiniz Değeri Giriniz:");
                            string kullaniciSilDeger = Console.ReadLine();
                            if (degerListesi.Contains(kullaniciSilDeger))
                            {
                                degerListesi.Remove(kullaniciSilDeger);
                                Console.WriteLine("Değriniz Silindi...");
                            }
                            else
                            {
                                Console.WriteLine("Silmek İstediğiniz Değer Liste İçerisinde Bulunamadı!!!");
                            }
                        }
                        break;
                    default:
                        break;
                } 
            }while (kullaniciSecim!="6") ;
        }
    }
}
