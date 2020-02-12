using System;
using System.IO;

namespace ZadaniaPrzedEgzaminem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = File.Create(path: "C:\\Users\\szkudlarz - m1\\Desktop\\Stronka\\plik.txt"))
            {
                Console.WriteLine("Egzamin P3");
            }

            using (StreamReader sr = File.OpenText())
            {
                string s;
                foreach ((s =.sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }

    static class ExtensionMethod
    {
        public static int Policz(this String napis, char c)
        {
            int licznik = 0;

            foreach(var a in napis)
            {
                if(a == c)
                {
                    licznik++;
                }
            }
            return licznik;
        }
    }
}
