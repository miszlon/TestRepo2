using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka_Przed_Kolosem_P3
{
    interface IDostawca
    {
        Produkt Wyszukaj(string nazwa);

        void Zamow(string nazwa);

    }
}
