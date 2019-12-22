using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__CS
{
    class Anggota
    {
        public string Nama = "Rizky Khapidsyah";
        public int Umur = 28;

        private int Saldo = 6000;

        public int getSaldo()
        {
            return Saldo;
        }

        public void setSaldo(int X)
        {
            Saldo += X;
        }
    }
}
