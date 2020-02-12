using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadania_w_Domu_4
{

    class Test
    {
        // nie da się zainicjalizowac dwóch takich samych konstruktorów. można robić więcej ale musze się różnic parametrami.

        //Lepiej inicjalizować ten konstruktor w klasie
        public Test(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }




        public string Name { get; set; }
        public string Surname { get; set; }

        public void WypiszImieNowegoPracownika()
        {
            Console.WriteLine("{0} to nasz nowy pracownik", Name);
        }
    }


    class Arrays
    {

        public static void ObliczanieWarotsci()
        {
            int[] Array1 = { 1000, 2000, 30000, 1000 };
            int suma = 0;

            for (int i = 0; i < Array1.Length; i++)
            {
                suma += Array1[i];
            }

            Console.WriteLine(suma);
        }

        public static int[] WprowadzanieDanych(int ArrayLength)
        {
            int[] Array = new int[ArrayLength];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Proszę podać wartość nr {0}:", i + 1);
                Array[i] = int.Parse(Console.ReadLine());
            }
            return Array;
        }

        public static void WypisywanieDanych(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Proszę podać długość tablicy");
            //Arrays.WypisywanieDanych(Arrays.WprowadzanieDanych(int.Parse(Console.ReadLine())));
            //Test test = new Test(Console.ReadLine(),Console.ReadLine());
            //Console.WriteLine(test.Name);

            //List<int> list  = new List<int>();
            //int[] tablica = new[] { 1, 2, 3, 4, 5 };
            //list.Add(10);
            //list.Add(12);
            //list.AddRange(tablica);
            //list.Insert(1, 20);
            //Random rand = new Random();

            //DateTime test = new DateTime(Math.Abs((long)rand.Next() * rand.Next()));

            //list<int> podzielnePrzez3 = list.Where(mojaWlasnaNazwa => mojaWlasnaNazwa > 3).ToList;

                //DateTime data = new DateTime(2000, 1, 28);
                //data.DayOfWeek
                //var daty = new List<DateTime>() { };
                //daty.Where(daty => daty.DayOfWeek == DayOfWeek.Friday).ToList();


            //Dictionary<int, string> slownik = new Dictionary<int, string>();
            //slownik.Add(0, "zero");
            //slownik.Add(2, "dwa");

            //Console.WriteLine(slownik[0]);
            //Console.WriteLine(slownik[2]);



            ////przelicza każdą "LICZBA" w liście "list" 
            //foreach (int liczba in list)
            //{
            //    Console.WriteLine(liczba);
            //}

            //------------DEKONSTRUKTOR--------------
            //Dekonstruktor obiekt = new Dekonstruktor
            //{
            //    Jednostka = "KMH",
            //    Predkosc = 100,
            //    Szybkosc = 200
            //};

            //int jakasSzybkosc;
            //string jakasJednostka;

            //(jakasSzybkosc, jakasJednostka) = obiekt.GetSzybkoscIJednostka();
            ////var wynik = obiekt.GetSzybkoscIJednostka();
            //(int mojaSzybkosc, _) = obiekt.GetSzybkoscIJednostka();

            //(int dekSzybkosc, int dekPredkosc, string dekJednostka) = obiekt;

            //--------------WYJĄTKI---------------

            //string text = "Test";

            //try
            //{
            //    int liczba = Convert.ToInt32(text);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("nie da się zrobić liczby z tego tekstu");
            //}
            //finally
            //{
            //    //nie ważne co się stanie, to zostanie wykonane
            //}

            //-------------------EVENT HANDLER-----------------
            var test = new Wyjątki();
            test.MojJakiEvent += Test_MojJakisEvent;

            test.F();

            
        }
        private static void Test_MojJakisEvent(object sender, EventArgs e)
        {
            Console.WriteLine("WYdarzyln sie blad");
        }

        private static void Test_MojJakisEvent2(object sender, EventArgs e)
        {
            Console.WriteLine("aaaa");
        }


    }
}
