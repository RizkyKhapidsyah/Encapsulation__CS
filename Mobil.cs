using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__CS
{
    class Mobil
    {
        public string Warna;
        public int Kecepatan;

        private int Saldo = 6000;

        public void Klakson()
        {
            Console.WriteLine("Telolett");
        }
    }
}
