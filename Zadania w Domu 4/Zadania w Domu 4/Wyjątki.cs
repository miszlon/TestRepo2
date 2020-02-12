using System;
using System.Collections.Generic;
using System.Text;

namespace Zadania_w_Domu_4
{
    class Wyjątki
    {
        public event EventHandler MojJakiEvent;
        public event EventHandler<MojeEventArgs> MojJakiEvent2;

        public void F()
        {
            MojJakiEvent?.Invoke(this, EventArgs.Empty);
            MojJakiEvent2?.Invoke(this, new MojeEventArgs() { Wiadomosc = "tekst" });
        }

        private static void EventHandlerWClass(object sender, EventArgs e)
        {
            Console.WriteLine("Wyjątki class");
        }

        public Wyjątki()
        {
            MojJakiEvent += EventHandlerWClass;
        }
    }

    public class MojeEventArgs :EventArgs
    {
        public string Wiadomosc { get; set; }
    }
}
