﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanici1 = string.Empty;

        yenidenSecim:

            Console.WriteLine("Ayınızı Giriniz ve Projenin Hangi Fazda Olduğunu Öğrenin...");
            kullanici1 = Console.ReadLine();
            switch (kullanici1)
            {
                case "1": 
                case "2": 
                case "3": 
                case "4":
                    Console.WriteLine("1.Faz");
                    break;
                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("2.Faz");
                    break;
                case "9":
                case "10":
                case "11":
                case "12":
                    Console.WriteLine("3.Faz");
                    break;

                default:
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz...");
                    goto yenidenSecim;

            }
            Console.ReadKey();
        }
    }
}
