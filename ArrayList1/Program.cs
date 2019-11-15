using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0;
            int count = 0;
            
            string[] isimler = new string[10];
            ArrayList A1 = new ArrayList();

            #region Tek Deger Ekleme
            A1.Add("Yakup Ali");
            capacity = A1.Capacity;
            count = A1.Count;
            A1.Add(100);
            #endregion

            #region Birden Fazla Değer Eklemek İşlemi
            ArrayList A2 = new ArrayList();
            A2.Add("Mehmet ");
            A2.Add("Merve ");
            A2.Add("Utkan");
            A1.AddRange(A2);
            #endregion

            #region capacity && count
            capacity = A1.Capacity;
            count = A1.Count;
            #endregion

            #region Koleksiyon İçindeki Değere Ulaşmak
            object O1 = A1[3];
            string S1 = A1[3].ToString() ;
            int I1 = (int)A1[1];
            A1[3] = "Hamza Atilla";
            #endregion
                
            #region
            //Dizinin mevcut elemanlarını ters olarak sıralama
            A1.Remove(100);
            A1.Reverse();
            //A'dan Z'ye Sıralama
            A1.Sort();
            #endregion

            #region Koleksiyonlar Yardımcı Komutları
            if (A1.Contains("Yakup"))
            {
                int IndexDegeri = A1.IndexOf("Yakup");
                A1.RemoveAt(IndexDegeri);
            }
            


            bool Kontrol1 = A1.Contains("Utkan");
            bool Kontrol2 = A1.Contains(900);


            object[] D1 = A1.ToArray();
            A1.Clear();
            A1.TrimToSize();

            #endregion

            #region ArrayList Koleksiyon İçindeki Değeri Silme
            A1.RemoveAt(3);
            A1.RemoveRange(2,2);
            A1.Remove("Hamza Atilla");
            #endregion

            #region 10 elemanlı (string) ArrayList içindeki Değerleri A'dan Z'ye sıralama

            ArrayList OdevList = new ArrayList();
            OdevList.Add("Zeynep");
            OdevList.Add("Özgür");
            OdevList.Add("Yakup");
            OdevList.Add("Ayşe");
            OdevList.Add("Gül");
            OdevList.Add("Hakan");
            OdevList.Add("Lale");
            OdevList.Add("Mustafa");
            OdevList.Add("Nilüfer");
            OdevList.Add("Özgür");
            OdevList.Add("Selim");

            //Adım 1:Tüm değerleri A'dan Z'ye sıralama
            OdevList.Sort();
            OdevList.Reverse();
            #endregion

        }
    }
}
