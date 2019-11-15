using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            object O1 = "Cengiz";
            bool veriTipiKontrol = O1 is int;
           

            object O2 = "Cengiz Atilla";
            string isim = O2 as string;
                Console.WriteLine("");
            #endregion
        }
    }
}
