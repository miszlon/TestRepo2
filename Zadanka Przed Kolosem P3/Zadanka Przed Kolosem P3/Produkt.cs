using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka_Przed_Kolosem_P3
{
    class Produkt
    {
        string Nazwa { set; get; }
        int Cena { get; set; }
        string Opis { get; set; }
        DateTime DataWaznosci
        {
            get { return DataWaznosci; }
            set { if (value < DateTime.Today) Console.WriteLine("mniej"); else Console.WriteLine("Wiecej"); } }
        int Ilosc { get; set; }

        public void Deconstruct(out string nazwa,out int cena)
        {
            nazwa = Nazwa;
            cena = Cena;
        }

        public void Deconstruct(out int cena, out string opis, out string dataWaznosci)
        {
            cena = Cena;
            opis = Opis;
            dataWaznosci = DataWaznosci.ToString();
            
        }

        
    }
}
