using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_Konsultacje_2
{
    class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Lewo(object sender, EventArgs e)
        {
            X--;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public void Prawo(object sender, EventArgs e)
        {
            X++;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public void Gora(object sender, EventArgs e)
        {
            Y++;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
        public void Dol(object sender, EventArgs e)
        {
            Y--;
            Console.WriteLine($"X: {X}, Y: {Y}");
        }

    }
}
