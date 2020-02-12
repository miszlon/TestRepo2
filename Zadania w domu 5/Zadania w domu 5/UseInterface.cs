using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_w_domu_5
{
    class UseInterface : I1
    {
        public UseInterface(string model, string typ, int ilosc)
        {
            Model = model;
            Typ = typ;
            Ilosc = ilosc;
        }

        private string Model { get; set; }
        private string Typ { get; set; }
        private int Ilosc { get; set; }

        public void WypiszDane()
        {
            Console.WriteLine(Model);
            Console.WriteLine(Typ);
            Console.WriteLine(Ilosc);
        }

        public int PodajIlosc()
        {
            return Ilosc;
        }

    }
}
