using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_Konsultacje_2
{
    class Hex
    {
        public Hex(string kod)
        {
            Kod = kod;
        }

        public string Kod { get; set; }

        public void Deconstruct(out string R, out string G, out string B)
        {
            R = Kod[0].ToString() + Kod[1].ToString();
            G = Kod[2].ToString() + Kod[3].ToString();
            B = Kod[4].ToString() + Kod[5].ToString();
            
        }

    }
}
