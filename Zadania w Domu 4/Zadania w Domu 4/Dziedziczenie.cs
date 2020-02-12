using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_w_Domu_4
{
    //dziedziczenie to możliwośc używania pól z klasy głównej w klasach, które dziedziczą z niej
    // tutaj klasa"Pies" dziedziczy "wizyty" z klasy "Zwierze"
   class Zwierze
    {
        //public List<DateTime> wizyty;

        DateTime dataUrodzenia;
        public Zwierze()
        {
            dataUrodzenia = DateTime.Now;
        }
    }
    
    class Pies :Zwierze
    {
        string rasa;

        public Pies(string nazwaRasy) : base()
        {
            rasa = nazwaRasy;
        }
    }
}
