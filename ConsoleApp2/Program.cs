using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba arabaTanimi1 = new Araba();
            arabaTanimi1.marka = "opel";
            arabaTanimi1.model = "Corse";
            arabaTanimi1.renk = "Mavi";
            Araba arabaTanimi2 = arabaTanimi1;
            arabaTanimi2.renk = "Gri";
            arabaTanimi2.model = "Astra";
            arabaTanimi1 = null;
            arabaTanimi2 = null;
        }
        }
    }

   class Araba
        {
            public string marka;
            public string model;
            public string renk;
        }