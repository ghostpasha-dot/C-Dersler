﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "250";
            string text2 = null;

            int sayi1 = -1;
            int sayi2 = -2;

            sayi1 = Convert.ToInt32(text1);
            sayi2 = Convert.ToInt32(text2);


            sayi1 = int.Parse(text1);
            sayi2 = int.Parse(text2);
             
        }
    }
}
