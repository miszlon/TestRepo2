using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadania_w_domu_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------IF   &   RANDOM--------------------
            //Random rand = new Random();
            //Console.WriteLine("Radnom number between 1 and 10 is: " + (rand.Next(1, 11)));
            //int age = 2;
            //bool czyMozeProwdazic = age >= 16 ? true : false;
            //Console.WriteLine(czyMozeProwdazic);

            //-----------------------SWITCH-----------------------------
            //switch (age)
            //{
            //    case 0: Console.WriteLine("Infant");
            //        break;
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Toddler");
            //        break;
            //}


            //--------------------------STRINGS------------------------
            //string randString = "Here are some radnom characters";

            //foreach(char c in randString)
            //{
            //    Console.WriteLine(c);
            //}

            //string sampString = "A bunch of random words";
            //string sampString2 = "More random words";
            //Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));
            //Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));
            //Console.WriteLine("String length: " + sampString.Length);
            //Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));
            //Console.WriteLine("2nd word " + sampString.Substring(2,6));
            //Console.WriteLine("string equal " + sampString.Equals(sampString2));
            //Console.WriteLine("Starts with \"A bunch\"" + sampString.StartsWith("A bunch "));
            //Console.WriteLine("Ends with \"words\"" + sampString.EndsWith("words "));

            //sampString = sampString.Trim();
            //sampString = sampString.Replace("words", "characters");
            //sampString = sampString.Remove(0, 2);
            //string[] names = new string[3] { "Matt", "joe", "greg" };

            //Console.WriteLine("Name list "+ String.Join(", ", names));

            //string formatString = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);
            //Console.WriteLine(formatString);

            //--------------STRING BUILDER----------------------------
            //StringBuilder sb = new StringBuilder();

            //sb.Append("to jest pierwsze zdanie");
            //sb.AppendFormat("Moje imie to: {0} i mieszkam w {1}", "Miłosz", "Osw");
            //sb.Replace("o", "l");

            //Console.WriteLine(sb.ToString());


            //-----------------------TABLICE JEDNOWYMIAROWE----------------------
            //int[] losowaTablicaNumeryczna;

            //int[] losowaTablica = new int[5];

            //int[] losowaTablica2 = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Długość Tablicy " + losowaTablica.Length);
            //Console.WriteLine("Wartość 0 " + losowaTablica[0]);

            //for (int i = 0; i < losowaTablica2.Length; i++)
            //{
            //    Console.WriteLine("{0} : {1}", i , losowaTablica2[i]);
            //}

            //foreach(int num in losowaTablica2)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("where is 2 " + Array.IndexOf(losowaTablica2,2));

            //string[] imiona = { "Milosz", "Adi", "kacper" };

            //string nameStr = string.Join(", ", imiona);

            //Console.WriteLine(nameStr);


            //---------------------------TABLICE WIELOWYMIAROWE-------------------

            //int[,] wieloTablica = new int[5, 3];

            //int[,] wieloTablica2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            //foreach (int num in wieloTablica2)
            //{
            //    Console.WriteLine(num);
            //}

            //for (int i = 0; i < wieloTablica2.GetLength(0); i++)
            //{
            //    for (int y = 0; y < wieloTablica2.GetLength(1); y++)
            //    {
            //        Console.WriteLine("{0} | {1} : {2}",i,y,wieloTablica2[i,y]);
            //    }
            //}

            //---------------------LISTY----------------

            //List<int> numList = new List<int>();

            //Random rand = new Random();

            //for(int i = 0; i < 10; i++)
            //{
            //    numList.Add(rand.Next(1, 101));
            //}

            //foreach(int display in numList)
            //{
            //    Console.WriteLine(display);
            //}

            //string[] typZakwaterowania = { "Dom", "Mieszkanie", "Willa", "Pałac" };

            //int randTable = rand.Next(typZakwaterowania.Length);

            //Console.WriteLine(typZakwaterowania[randTable]);

            //int[] table = { 1, 2, 3, 4, 5 };

            //List<int> lista = new List<int>(table);
            //foreach(int liczba in lista)
            //{
            //    Console.WriteLine(liczba);
            //}

            //Console.WriteLine("4 jest na miejscu {0} w tablicy", lista.IndexOf(4));

            //---------------------WYJĄTKI---TRY-CATCH----EXCEPTIONS-------------
            //TUTAJ W CATCH WPISUJMEY TEN WYJĄTEK KTÓRY CHCEMY WYSZUKAĆ W DZIAŁANIU PROGRAMU
            //WYJĄTEK ZWRACAJĄCY WSZYSTKIE WYJĄTKI TO PO PROSTU EXCEPTION.

            //try
            //{
            //    Console.Write("Dzielimy 10 przez: ");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine("10 / {0} = {1}", num, (10 / num));
            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Nie można dzielić przez 0!");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}


            //try
            //{
            //    Console.WriteLine("Podaj liczbe");
            //    int liczba = int.Parse(Console.ReadLine());
            //}

            //catch (Exception)
            //{
            //    Console.WriteLine("TO NIE JEST LICZBA!");
            //}



            //----------------------------KLASY I OBIEKTY----------------------

            //Animal pies = new Animal(190, 50, "wof", "Doggy");
            //Animal kot = new Animal(12, 45, "miau", "kicia");

            //Console.WriteLine(pies.Weight);
            //Console.WriteLine("{0} says {1}",pies.Name,pies.Sound);
            //Console.WriteLine("Ilosc zwierząt " + Animal.getNumOfAnimals());
            //Console.WriteLine(pies.opisZwierzecia());


            //------------------------------ENUM---------------------------------------
            //Temrepartuta micTemp = Temrepartuta.Low;

            //switch (micTemp)
            //{
            //    case Temrepartuta.Freez:
            //        Console.WriteLine("Temp on freezing");
            //        break;
            //    case Temrepartuta.Low:
            //        Console.WriteLine("temp on low");
            //        break;
            //    case Temrepartuta.Warm:
            //        global::System.Console.WriteLine("temp is Warom");
            //        break;
            //    case Temrepartuta.Boil:
            //        Console.WriteLine("temp is boil");
            //        break;
            //}


        }
    }

    public enum Temrepartuta
    {
        Freez,
        Low,
        Warm,
        Boil
    }


    abstract class Shape
    {
        public abstract double area();

        public void siHi()
        {
            Console.WriteLine("hello");
        }
    }

    public interface I1
    {
        double area();
    }

    class Rectangle : Shape
    {

        private double length;
        private double width;
        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }
    }

    class Triangle : Shape
    {

        private double theBase;
        private double height;
        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return 5 * (theBase * height);
        }
    }

}
