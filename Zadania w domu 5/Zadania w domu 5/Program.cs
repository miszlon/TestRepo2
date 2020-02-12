using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadania_w_domu_5
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();

            int miesiac = random.Next(1, 12);
            int dzien = random.Next(1, 30);

            List<DateTime> data = new List<DateTime>();

            for (int i = 0; i < 200; i++)
            {
                data.Add(new DateTime(random.Next(1, 2000), random.Next(1, 11), random.Next(1, 26)));
            }
            foreach (var daty in data)
            {
                Console.WriteLine(daty.ToString("yyyy MM dd"));
            }
            

            

            //Console.WriteLine(miesiac);

            //List<int> liczby = new List<int>();
            
            //for(int i = 1;i < 201; i++)
            //{
            //    liczby.Add(i);
            //}
            //foreach(int element in liczby)
            //{
            //    Console.WriteLine(element);
            //}

        }
    }
}
