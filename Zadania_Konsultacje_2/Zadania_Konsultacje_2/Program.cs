using System;
using System.Collections.Generic;
using System.Linq;


namespace Zadania_Konsultacje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Z1
            //----------Zadanie 1 kolokwium--------------
            //List<Produkt> produkty = new List<Produkt>();
            //List<Składnik> skladnik1 = new List<Składnik>();
            //skladnik1.Add(new Składnik(100, 32, 5));
            //skladnik1.Add(new Składnik(50, 50, 0));
            //skladnik1.Add(new Składnik(100, 0, 0));
            //produkty.Add(new Produkt(skladnik1));


            //List<Składnik> skladnik2 = new List<Składnik>();
            //skladnik2.Add(new Składnik(10000, 32, 1005));
            //skladnik2.Add(new Składnik(500, 50, 10));
            //skladnik2.Add(new Składnik(10000, 0, 200));
            //produkty.Add(new Produkt(skladnik2));


            //foreach(var i in produkty)
            //{
            //    Console.WriteLine($"Weglowodany {i.lista.Sum(x=>x.Weglowodany)}");
            //    Console.WriteLine($"Tluszcze {i.lista.Sum(x => x.Tluscze)}");
            //    Console.WriteLine($"Sole {i.lista.Sum(x => x.Sol)}");

            //}
            #endregion
            #region Z3
            //--------Zadanie 3 kolokwium---------------
            //Wykożystanie dekonstruktora polega na napisaniu jego wartosci w nawiasie i przypisaniu do niego nowej wartosic

            //Hex obiekt = new Hex("FFAAEE");
            //var (r, g, b) = obiekt;
            #endregion
            #region Z5
            //-----------Zadanie 5 kolokwium------------------

            //Panel panel = new Panel();
            //Robot robot = new Robot();

            ////Żeby przypisać EVENT nie wystarczy samo =   Trzeba pisać to +=    !!!!!!!!!!!!!!!!!!!!!!!
            //panel.LEFT += robot.Lewo;
            //panel.RIGHT += robot.Prawo;
            //panel.UP += robot.Gora;
            //panel.DOWN += robot.Dol;

            ////Wywołanie funkcji wyświetlających te eventy.
            //panel.Left();
            //panel.Up();
            //panel.Right();
            //panel.Down();
            #endregion

            #region Z3F
            Postać postac = new Postać();
            postac.Kolejka();
            postac.status = Status.Spowolnienie;
            postac.Kolejka();
            postac.Kolejka();
            postac.status = Status.Trucizna;
            postac.Kolejka();


            #endregion



        }

    }
}
