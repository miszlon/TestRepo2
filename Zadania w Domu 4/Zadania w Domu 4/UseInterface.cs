using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_w_Domu_4
{
    class UseInterface : I7
    {
        public UseInterface(string rodzaj, string model, int ilosc)
        {
            Rodzaj = rodzaj;
            Model = model;
            Ilosc = ilosc;
        }

        private string Rodzaj { get; set; }
        private string Model { get; set; }
        private int Ilosc { get; set; }
        public int DodajPola()
        {
            return Ilosc;

        }

        public void WypiszDane()
        {
            Console.WriteLine("Rodzaj: {0}", Rodzaj);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Ilosc: {0}", Ilosc);
        }
    }
}
