using System;

namespace thirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 ed verilib (a,b,c,d). bu ededlerin ilk ikicemleyib, oğlu hasilini tapmaq. sonda ise cemi hasile bolmek. ve cavabi cap etmek (cem/hasil)


            double a = 8, b = 6, c = 4, d = 2, cem, hasil, bolme;



            cem = a + b;

            hasil = c * d;

            bolme = cem / hasil;

            Console.WriteLine(bolme);
            Console.ReadKey();
        }
    }
}
