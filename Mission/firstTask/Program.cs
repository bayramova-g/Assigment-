using System;

namespace firstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //73 ededinin tek olub olmamasi

            int a = 73;
            if (a % 2 == 0)
            {
                Console.WriteLine("number is even");


            }
            else
            {
                Console.WriteLine("number is odd");
            }


            Console.ReadKey();
        }
    }
}
