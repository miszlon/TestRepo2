using System;

namespace Zadanka_w_domu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string wybraneZadanie;
            string[] numerZadania = { "A", "B", "C", "D" };
            int liczbaZadan = 3;
            Console.WriteLine("Zadania do wykonania:");
            for(int i = 1; i <= liczbaZadan; i++)
            {
                Console.WriteLine("Poziom trudności zadania: " + i);
                for (int y = 0; y < numerZadania.Length; y++)
                {
                    Console.WriteLine("Zadanie" + i + numerZadania[y]);
                }
            }
            Console.WriteLine("Podaj numer zadania które chcesz wykonać (2 ostatnie znaki):");
            wybraneZadanie = Console.ReadLine();
            switch (wybraneZadanie)
            {
                case "1A":
                    //1A.Napisz funkcję, która zwróci wynik w / g wzoru: y = 2 * x ^ 3 - 8 * x ^ 2 - 3 * x + 10
                    double liczba1A;
                    Console.WriteLine("Zadanie 1A - Napisz funkcję, która zwróci wynik w / g wzoru: y = 2 * x ^ 3 - 8 * x ^ 2 - 3 * x + 10");
                    Console.WriteLine("Podaj liczbę do zadania 1A");
                    liczba1A = double.Parse(Console.ReadLine());
                    Console.WriteLine("Wynik: " + Zadania.Zadanie1A(liczba1A));
                    break;

                case "1B": 
                    //1B.Napisz funkcję standaryzacji wartości. Liczbę z przedziału 50 - 150 przeskaluj do przedziału 0 - 1.y = ((x - 50) / (150 - 50))
                    Console.WriteLine("Zadanie 1B -Napisz funkcję standaryzacji wartości. Liczbę z przedziału 50-150 przeskaluj do przedziału 0-1. y=( (x-50) / (150 - 50))");
                    Console.WriteLine("Podaj liczbę z przedziału od 50 do 150");
                    double liczba1B = double.Parse(Console.ReadLine());
                    if (liczba1B < 50 && liczba1B > 150)
                    {
                        Console.WriteLine("Przeskalowana wartość to: " + Zadania.Zadanie1B(liczba1B));
                    }
                    else Console.WriteLine("Liczba z poza przedziału <50, 150>");
                    break;

                case "1C":
                    //1C.Napisz funkcję, która oblicza pole trapezu.Wzór: ((a + b) / 2) * h
                    Console.WriteLine("Zadanie 1C - Napisz funkcję, która oblicza pole trapezu. Wzór: ((a+b)/2) * h");
                    Console.WriteLine("Podaj bok a trapezu: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj bok b trapezu: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość trapezu: ");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("Pole trapezu = " + Zadania.Zadanie1C(a, b, h));
                    break;

                case "1D":
                    //1D.Napisz funkcję, która sprawdzi, czy podany punkt należy do wykresu funkcji o wzorze: y = 0.5 * x ^ 2 - 10 * x + 1
                    Console.WriteLine("Zadanie 1D - Napisz funkcję, która sprawdzi, czy podany punkt należy do wykresu funkcji o wzorze: y=0.5*x^2-10*x+1");
                    Console.WriteLine("Podaj wartość x dla punktu ");
                    double wartoscX = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj wartość y dla punktu ");
                    double wartoscY = double.Parse(Console.ReadLine());
                    Zadania.Zadanie1D(wartoscX,wartoscY);
                    break;

                case "2A":
                    //2A.W podanej tablicy znajdują się zyski ze sprzedaży danego dnia. Utwórz tablicę która będzie zawierać sumę zysków danego dnia od początku miesiąca.
                    Console.WriteLine("Zadanie 2A - W podanej tablicy znajdują się zyski ze sprzedaży danego dnia. Utwórz tablicę która będzie zawierać sumę zysków danego dnia od początku miesiąca.");
                    double[] zyski = { 1000, 15000, 2000, 3000 };
                    Console.WriteLine("Suma zysków: " + Zadania.Zadanie2A(zyski));
                    break;

                case "2B":
                    //2B.W podanej tablicy znajdują się wyniki obliczeń.Sprawdź i wypisz na konsoli czy liczby spełniają warunek(liczba % (indeks + 1) == 0)
                    Console.WriteLine("Zadanie 2B - W podanej tablicy znajdują się wyniki obliczeń. Sprawdź i wypisz na konsoli czy liczby spełniają warunek (liczba % (indeks+1) == 0)");
                    double[] wyniki = { 8,4 , 2, 1 };
                    if (Zadania.Zadanie2B(wyniki) == true)
                    {
                        Console.WriteLine("Warunek spełniony");
                    }
                    else Console.WriteLine("Warunek niespełniony"); ;
                    break;

                case "2C":

                    //2C.Wypisz podany tekst od tyłu
                    Console.WriteLine("Zadanie 2C - Wypisz podany tekst od tyłu");
                    Console.WriteLine("Podaj tekst: ");
                    string tekst = Console.ReadLine();
                    Zadania.Zadanie2C(tekst);
                    break;

                case "2D":
                    //2D.Szyfr Cezara.Podany tekst przesuń o ilość znaków wybraną przez użytkownika.Wypisz szyfr na ekran. Pomiń zapętlenie(z -> a).
                    Console.Write("Podaj tekst do przekonwertowania: ");
                    string tekstCezara = Console.ReadLine();
                    Console.Write("O ile chcesz przesunąć tekst: ");
                    int przesuniecie = int.Parse(Console.ReadLine());
                    Zadania.Zadanie2D(tekstCezara, przesuniecie);
                    break;

                case "3A":
                    //3A.Stwórz funkcję, która zwróci głeboką kopię dwuwymiarowej tablicy poszarpanej jako dwuwymiarową tablicę prostokątną. Tablica poszarpana nie musi być prostokątna.
                    break;

                case "3B":
                    //3B.W tablicy poszarpanej są zapisane identyfikatory pracowników.Każdy wiersz to jeden dział.Napisz funkcję, która wypisze ilu pracowników ma który dział.
                    // Wypisz, który dział ma najwięcej pracowników.Wypisz, w którym dziale pracuje najnowszy pracownik(najwyższe id).
                    Zadania.Zadanie3B();
                    break;

                case "3C":
                    //3C.Tworzysz aplikację, która ma działać w systemie o krytycznie niskiej ilości pamięci RAM. Aplikacja otrzymuje dane w postaci dwuwymiarowej tablicy prostokątnej,
                    //mimo że większość rzędów jest zakończona szeregiem bezużytecznych wartości(zer). Aby zaoszczędzić pamięć, 
                    //napisz funkcję która przetworzy tablicę prostokątną na tablicę poszarpaną.
                    Zadania.Zadanie3C();
                    break;

                case "3D":
                    //3D.Napisz funkcję która przeszuka tablicę poszarpaną i wypisze rząd i kolumnę wartości przyjętej w parametrze.
                    Console.Write("Podaj numer parametru: ");
                    int parametr = int.Parse(Console.ReadLine());
                    Zadania.Zadanie3D(parametr);
                    break;
    
            }
        }


    }
}
