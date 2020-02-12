using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_Konsultacje_2
{
    public class Składnik
    {
        public Składnik(int weglowodany, int tluscze, int sol)
        {
            Weglowodany = weglowodany;
            Tluscze = tluscze;
            Sol = sol;
        }

        public int Weglowodany { get; set; }
        public int Tluscze { get; set; }
        public int Sol { get; set; }

    }
}
