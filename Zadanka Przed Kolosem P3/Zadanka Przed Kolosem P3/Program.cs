using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanka_Przed_Kolosem_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------ZADANIE 1A-------------------------
            //Random rand = new Random();

            //List<int> lista = new List<int>();
            //for(int i = 0; i < 100; i++)
            //{
            //    lista.Add(rand.Next(-1000, 1001));
            //}

            //Console.WriteLine(lista.Count);
            //Console.WriteLine(lista.Average());
            //Console.WriteLine(lista.Max());
            //Console.WriteLine(lista.Min());
            //Console.WriteLine(lista.Sum());

            //int counterMinus = 0;
            //int counterPlus = 0;
            //foreach(var a in lista)
            //{

            //    if(a<0)
            //    {
            //        counterMinus++;
            //    }
            //    if(a>0)
            //    {
            //        counterPlus++;
            //    }
            //}
            //Console.WriteLine(counterPlus);
            //Console.WriteLine(counterMinus);



            //---------------------ZADANIE 1B------------------------------
            List<DateTime> listaDat = new List<DateTime>();
            Random RandData = new Random();



            for (int i = 0; i < 200; i++)
            {
                listaDat.Add(new DateTime(RandData.Next(1, 2020),RandData.Next(1, 12), RandData.Next(1,28)));
            }


            listaDat.Sort();
            //foreach(var item in listaDat)
            //{
            //    Console.WriteLine(item.ToString("dd MM yyyy"));
            //}

            //foreach(var item in listaDat)
            //{
            //    if(item.DayOfWeek == DayOfWeek.Friday)
            //    {
            //        Console.WriteLine("Piątek: {0}", item.ToString("yyyy MM dd"));
            //    }
            //}

            //foreach(var item in listaDat)
            //{
            //    int suma = item.Year + item.Month + item.Day;
            //    Console.WriteLine(suma);
            //}


            //------------Zadanie 2A----------------
            //Telefon nokia3310 = new Telefon();
            //Smartfon xPhone = new Smartfon();
            //xPhone.LadujStroneWWWW("www.adresstrony.pl");

            //--------------Zadanie 3A------------------

                       

        }
    }
}
