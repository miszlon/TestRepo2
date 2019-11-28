using System;
using System.IO;

namespace Zadanka_w_domu
{
    class Program
    {

        static double[] ReadNumbersFromFile(string fileName)
        {
            List<double> numbers = new List<double>();
            using (StreamReader file = File.OpenText(fileName)) ;
            while(!File.EndOfStream)
            {
                string line = File.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    numbers.Add(double.Parse(line));
                }
            }
        }
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("LapTimes.txt");
            double currentLapStartTime = 0;
            double fastestLapTime = 0;
            int lapNumber = 0;
            int fastestLapNumber = 0;
            foreach (string line in lines)
            {

                Console.WriteLine(line);
                //double lapEndTime = double.Parse(line);
                //double lapTime = lapEndTime - currentLapStartTime;
                //if (fastestLapTime == 0 || lapEndTime < fastestLapTime)
                //{
                //    fastestLapTime = lapTime;
                //    fastestLapNumber = lapNumber;


                //}
                //currentLapStartTime = lapEndTime;
                //lapNumber += 1;
            }
            Console.WriteLine("Najszybsze okrążenie: " + fastestLapNumber);
            Console.WriteLine("Czas najszybszego okrążenia: " + fastestLapTime);
        }
    }
}
