using System;

namespace Zadanka_w_domu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadania z kolokwium 1
            //Zadanie 1A. Napisz funkcję, która zwróci wynik w/g wzoru: y=2*x^3-8*x^2-3*x+10

            Console.WriteLine("Porszę podaj wartość x: ");
            double Liczba = double.Parse(Console.ReadLine());
            Console.WriteLine("Wartość y = " + Zadania.Zadanie1A(Liczba));
        }
    }
}
