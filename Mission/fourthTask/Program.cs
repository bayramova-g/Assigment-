using System;

namespace fourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - 50 arasi(1 ve 50 de daxil olmaqla[1.50]) butun tek ededleri cap
            for (int i = 0; i <= 50; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
