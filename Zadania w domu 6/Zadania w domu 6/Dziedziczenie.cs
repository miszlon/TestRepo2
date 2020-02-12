using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_w_domu_6
{
    class Dziedziczenie
    {
       static void Wyswietlanie()
        {
            Ziemia ziemia = new Ziemia();
            ziemia.Nazwa = "LOL";
            CialoNiebieskie cialoNiebieskie = new CialoNiebieskie();
            cialoNiebieskie.Nazwa = "CIAAAAALOOO";

            Console.WriteLine(cialoNiebieskie.Nazwa);
            Console.WriteLine(ziemia.Nazwa);

            ziemia.RuchObrotowy();
            
        }
     
    }

    class Planeta : CialoNiebieskie
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pory dnia i nocy");
        }
    }

    class Ziemia : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Ziemia ma atmosfere");
        }
    }
    class CialoNiebieskie
    {
        public string Nazwa { get; set; }
        public void RuchObrotowy()
        {
            Console.WriteLine("Kazda planeta ma ruch obrotowy");
        }
    }
    
}
