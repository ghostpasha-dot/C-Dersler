using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();
            #region Yeni Değer Ekleme
            H1.Add("Car","Araba");
            H1.Add("House","Ev");

            H1.Add("Cars","Araba");
            //H1.Add("Cars","Arabalar"); Key Değeri Benzersiz Olmak Zorundadır.

            #endregion

            #region Yardımcı Metotlar

            bool Kontrol1=H1.Contains("House");
            bool Kontrol2=H1.Contains("Houseoor");

            bool Kontrol3 = H1.ContainsKey("House");
            bool Kontrol4 = H1.ContainsValue("Araba");

            H1["House"] = "Villa";

            H1.Remove("Cars");
            int koleksiyonİcindekiToplamDeger = H1.Count;
            H1.Clear();//Koleksiyon İçerisindeki Tüm Datayı Temizler

            
            #endregion
        }
    }
}
