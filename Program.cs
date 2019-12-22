using System;

namespace Encapsulation__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Anggota Kelompok1 = new Anggota();

            string NamaMain = Kelompok1.Nama;
            int UmurMain = Kelompok1.Umur;

            int SaldoMain = Kelompok1.getSaldo();

            Console.WriteLine("Nama = {0}, Umur = {1}, Saldo = {2}\n\n", NamaMain, UmurMain, SaldoMain);
            Console.WriteLine("Nama  : " + NamaMain);
            Console.WriteLine("Umur  : " + UmurMain);
            Console.WriteLine("Saldo : " + SaldoMain +"\n\n");

            Kelompok1.Nama = "Riky";
            Kelompok1.Umur = 25;

            NamaMain = Kelompok1.Nama;
            UmurMain = Kelompok1.Umur;
            Kelompok1.setSaldo(20000000);

            Console.WriteLine("Nama = {0}, Umur = {1}, Saldo = {2}\n\n", NamaMain, UmurMain, SaldoMain);
            Console.WriteLine("Nama  : " + NamaMain);
            Console.WriteLine("Umur  : " + UmurMain);
            Console.WriteLine("Saldo : " + SaldoMain + "\n\n");

            Console.ReadLine();
        }
    }
}
