using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;
            //Bilinçli Tür Dönüşü
            int sayi2 = 125;
            sayi1 = (byte)sayi2;
            Console.WriteLine(sayi1);
            //Bilinçsiz Tür Dmnüşümü
            double sayi3 = 10;
            sayi3 = sayi2;
            Console.WriteLine(sayi3);
            //Checked-Unchecked
            unchecked {
            sayi2 = 512;
            sayi1 = (byte)sayi2;
            }
            
            //checked
            //{
            //    sayi2 = 512;
            //    sayi1 = (byte)sayi2;
            //}


            object temelTip = sayi2;
            temelTip = sayi3;
            temelTip = new
            {
                marka = "Opel",
                model = "Corse",
            };
            temelTip = sayi2;
            sayi2 = (int)temelTip;
            Console.Write("");

        }
    }
}
