using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_Konsultacje_2
{
    class Postać
    {
        private bool spowolniony = false;
        public Postać()
        {
            HP = 10;

        }
        public int HP { get; set; }
        public Status status { get; set; }

        public void Kolejka()
        {

            switch (status)
            {
                case Status.Normalny:
                    Console.WriteLine("Co robisz");
                    Console.ReadLine();
                    break;
                case Status.Trucizna:
                    HP -= 2;
                    break;
                case Status.Ogluszenie:
                    Console.WriteLine("Tracisz kolejke");
                    status = status & ~Status.Ogluszenie;
                    break;
                case Status.Uciszenie:
                    break;
                case Status.Spowolnienie:
                    if (spowolniony)
                    {
                        Console.WriteLine("Tracisz kolejke");
                    }
                    else
                    {
                        Console.WriteLine("Co zrobisz?");
                        Console.ReadLine();
                        spowolniony = true;
                    }
                    break;
                case Status.Szal:
                    Console.WriteLine("Postac ruszyla do ataku");
                    break;
            }
        }
    }
}
