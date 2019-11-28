using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanka_w_domu_2
{
    class Zadania
    {
        //Zadanie 1A - Napisz funkcję, która zwróci wynik w/g wzoru: y=2*x^3-8*x^2-3*x+10
        public static double Zadanie1A(double x)
        {
            double y = 2 * Math.Pow(x, 3) - 8 * Math.Pow(x, 2) - 3 * x + 10;
            return y;
        }

        //Zadanie 1B - Napisz funkcję standaryzacji wartości. Liczbę z przedziału 50-150 przeskaluj do przedziału 0-1. y=( (x-50) / (150 - 50))

        public static double Zadanie1B(double x)
        {
            double y = ((x - 50) / (150 - 50));
            return y;

        }

        //Zadanie 1C - Napisz funkcję, która oblicza pole trapezu. Wzór: ((a+b)/2) * h
        public static double Zadanie1C(double a, double b, double h)
        {
            double y = ((a + b) / 2) * h;
            return y;
        }
        //Zadanie 1D - Napisz funkcję, która sprawdzi, czy podany punkt należy do wykresu funkcji o wzorze: y=0.5*x^2-10*x+1

        public static bool Zadnaie1D(double x, double y)
        {

            Console.WriteLine("Sprawdzamy czy punk A(" + x + "," + y + ") należy do wykresu");
            double wynik = y;

            if (wynik == (0.5 * Math.Pow(x, 2)) - (10 * x) + 1)
            {
                return true;
            }
            else return false;
        }

        //Zadanie 2A - W podanej tablicy znajdują się zyski ze sprzedaży danego dnia. Utwórz tablicę która będzie zawierać sumę zysków danego dnia od początku miesiąca.
        public static double Zadanie2A(double[] zyski_z_dnia)
        {
            double zysk = 0;
            double zmienna = 0;
            for (int i = 0; i < zyski_z_dnia.Length; i++)
            {
                zyski_z_dnia[i] = zmienna;
                zysk += zmienna;
            }
            return zysk;
        }

        //Zadanie 2B - W podanej tablicy znajdują się wyniki obliczeń. Sprawdź i wypisz na konsoli czy liczby spełniają warunek (liczba % (indeks+1) == 0)
        public static bool Zadanie2B(double[] wyniki, int ktoraLiczba)
        {
            double dzialanie = (wyniki[ktoraLiczba] % wyniki[ktoraLiczba + 1]);
            if (dzialanie == 0)
                return true;
            else return false;
        }

        //Zadanie 2C - Wypisz podany tekst od tyłu

        public static void Zadanie2C(string tekst)
        {
            char[] tekstPrzychodzacy = tekst.ToCharArray();
            for (int i = tekstPrzychodzacy.Length; i >= 1; --i)
            {

                Console.Write(tekstPrzychodzacy[i - 1]);

            }
        }

        //Zadanie 2D - Szyfr Cezara. Podany tekst przesuń o ilość znaków wybraną przez użytkownika. Wypisz szyfr na ekran. Pomiń zapętlenie (z -> a).

        public static void Zadanie2D(string tekst, int przesuniecie)
        {
            char[] tekstCezara = tekst.ToCharArray();
            for (int i = 0; i < tekstCezara.Length; i++)
            {
                Console.WriteLine(tekstCezara[i]+przesuniecie);
            }
        }

    }
}
