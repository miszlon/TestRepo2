using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_Konsultacje_2
{
    [Flags]
    enum Status
    {
        Normalny = 0,           //00000
        Trucizna = 1,           //00001
        Ogluszenie = 2,         //00010
        Uciszenie = 4,          //00100
        Spowolnienie = 8,       //01000
        Szal = 16,              //10000

    }
}
