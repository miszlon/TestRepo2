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

        public static bool Zadanie1D(double x, double y)
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
            double zmienna;
            for (int i = 0; i < zyski_z_dnia.Length; i++)
            {
                zmienna = zyski_z_dnia[i];
                zysk += zmienna;
            }
            return zysk;
        }

        //Zadanie 2B - W podanej tablicy znajdują się wyniki obliczeń. Sprawdź i wypisz na konsoli czy liczby spełniają warunek (liczba % (indeks+1) == 0)
        public static bool Zadanie2B(double[] wyniki)
        {
            int zmienna = 0;
            for (int i = 0; i < wyniki.Length - 1; i++)
            {
                if (wyniki[i] % wyniki[i + 1] == 0)
                {
                    zmienna = 1;
                }
                else zmienna = 0;
            }
            if (zmienna == 1)
            {
                return true;
            }
            else return false;
        }

        //Zadanie 2C - Wypisz podany tekst od tyłu

        public static void Zadanie2C(string tekst)
        {
            char[] tekstPrzychodzacy = tekst.ToCharArray();
            for (int i = tekstPrzychodzacy.Length; i > 0; i--)
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
                Console.WriteLine(tekstCezara[i] + przesuniecie);
            }
        }

        //Zadanie 3A - Stwórz funkcję, która zwróci głeboką kopię dwuwymiarowej tablicy poszarpanej jako dwuwymiarową tablicę prostokątną. Tablica poszarpana nie musi być prostokątna.
        public static void Zadanie3A()
        {
            int[][] poszarpanaTablica3A =
            {
                new[] {1,34,5,32 },
                new[] {1,345,5,774,2,45,6,3,3,4 },
                new[] {4,23,45,6,78,5,4,3,3,6,3,3,5,5,43,3,34,4,5543,56435654,6 }
            };

            int[,] prostokatnaTablica3A;

            for(int i = 0; i < poszarpanaTablica3A.Length;i++)
            {
                for(int j = 0; j < poszarpanaTablica3A[i].Length; j++)
                {

                }
            }

        }


        //Zadanie 3B - W tablicy poszarpanej są zapisane identyfikatory pracowników. Każdy wiersz to jeden dział. Napisz funkcję, która wypisze ilu pracowników ma który dział.
        //             Wypisz, który dział ma najwięcej pracowników. Wypisz, w którym dziale pracuje najnowszy pracownik (najwyższe id).

        public static void Zadanie3B()
        {
            int iloscPracownikow = 0;
            int dzial = 0;
            int identyfikator = 0;
            int najnowszyPracownik = 0;
            int[][] identyfikatory =
            {
                new[] {10,4,6,10, 45, 32, 54},
                new[] {15,22,3},
                new[] {40,60,80,100,120 }
            };


            for (int i = 0; i < identyfikatory.Length; i++)
            {
                if (iloscPracownikow < identyfikatory[i].Length)
                {
                    iloscPracownikow = identyfikatory[i].Length;
                    dzial = i;
                };

                Console.WriteLine("Element({0}) - {1}: ", (i + 1), identyfikatory[i].Length);
            }
            Console.WriteLine("Dział {0} ma największą liczbę pracowników", dzial + 1);

            for (int i = 0; i < identyfikatory.Length; i++)
            {
                for (int y = 0; y < identyfikatory[i].Length; y++)
                {
                    if (najnowszyPracownik < identyfikatory[i][y])
                    {
                        najnowszyPracownik = identyfikatory[i][y];
                        dzial = i;
                        identyfikator = identyfikatory[i][y];
                    };
                }
            }
            Console.WriteLine("Najnowszy pracownik jest w dziale {0}, o identyfikatorze {1}", dzial + 1, identyfikator);
        }

        //Zadanie 3C - Tworzysz aplikację, która ma działać w systemie o krytycznie niskiej ilości pamięci RAM. Aplikacja otrzymuje dane w postaci dwuwymiarowej tablicy prostokątnej,
        //              mimo że większość rzędów jest zakończona szeregiem bezużytecznych wartości(zer). Aby zaoszczędzić pamięć, 
        //              napisz funkcję która przetworzy tablicę prostokątną na tablicę poszarpaną.

        public static void Zadanie3C()
        {
            int[,] iloscPamieci = { { 2, 3, 5, 0 }, { 2, 4, 0, 0 } };

            int[][] poszarpanaIloscPamieci = new int[iloscPamieci.Length][];

            //wyświetlanie tablicy dwuwymiarowej
            for (int i = 0; i < iloscPamieci.GetLength(0); i++)
            {
                for (int y = 0; y < iloscPamieci.GetLength(1); y++)
                {
                    if (y == iloscPamieci.GetLength(1) - 1)
                    {
                        Console.WriteLine(iloscPamieci[i, y]);
                    }
                    else Console.Write(iloscPamieci[i, y]);
                }
            }

            //usuwanie zer na końcu
            for (int i = 0; i < iloscPamieci.GetLength(0); i++)
            {
                for (int y = 0; y < iloscPamieci.GetLength(1); y++)
                {
                    if (iloscPamieci[i, y] != 0)
                    {
                        poszarpanaIloscPamieci[i][y] = iloscPamieci[i, y];
                    }
                }
            }

        }

        //Zadanie 3D - Napisz funkcję która przeszuka tablicę poszarpaną i wypisze rząd i kolumnę wartości przyjętej w parametrze.
        public static void Zadanie3D(int parametr)
        {
            int[][] tablicaPoszarpana3D =
            {
                new[] { 3, 56, 34 },
                new[] { 34534, 544, 242424, 3, 4, 5, 2 },
                new[] { 5333, 12222, 34444, 56666, 78888 }
            };

            for (int i = 0; i < tablicaPoszarpana3D.Length; i++)
            {
                for (int y = 0; y < tablicaPoszarpana3D[i].Length; y++)
                {
                    if (parametr == tablicaPoszarpana3D[i][y])
                    {
                        Console.WriteLine("Parametr znaleziony! Rząd {0}, wierz {1}", i + 1, y + 1);
                    }
                }
            }

        }
    }
}
