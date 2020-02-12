using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_w_Domu_4
{
    public class Dekonstruktor
    {

        public int Szybkosc { get; set; }
        public string Jednostka { get; set; }
        public int Predkosc { get; set; }

        public int GetSzybkosc()
        {
            return Szybkosc;
        }

        public (int tuDostanieszSzybkosc, string tuDostanieszJednostke) GetSzybkoscIJednostka()
        {
            return (Szybkosc, Jednostka);
        }

        public void Deconstruct(out int x, out int y, out string z)
        {
            x = Predkosc;
            y = Szybkosc;
            z = Jednostka;
        }
    }
}
