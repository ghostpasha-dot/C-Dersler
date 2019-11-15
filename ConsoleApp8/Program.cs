using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int sayi1 = 10;
            #endregion

            #region
            sayi1 += 2;
            Console.WriteLine(sayi1);
            #endregion
            #region
            sayi1 -= 2;
            Console.WriteLine(sayi1);
            #endregion
            #region
            sayi1 *= 2;
            Console.WriteLine(sayi1);
            #endregion
            #region
            sayi1 /= 2;
            Console.WriteLine(sayi1);
            #endregion
        }
    }
}
