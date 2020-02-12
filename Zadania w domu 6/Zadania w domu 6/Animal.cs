using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_w_domu_6
{

    class Animal
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Sound { get; set; }

        public string Name { get; set; }

        public Animal(double height, double weight, string sound, string name)
        {
            Height = height;
            Weight = weight;
            Sound = sound;
            Name = name;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string opisZwierzecia()
        {
            return String.Format("{0} is {1} inches tall, weight {2} lbs and like to say {3}", Name, Height, Weight, Sound);
        }

        //---------------DEKONSTRUKTOR----------------------
        public void Deconstruct(out double height, out string name)
        {
            height = Height;
            name = Name;
        }



    }
}
