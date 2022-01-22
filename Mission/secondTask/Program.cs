using System;

namespace secondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //ededin 4e bolunub bolunmediyi


            Console.Write("please enter a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 4 == 0)
            {

                Console.WriteLine("Bolunur");


            }

            else
            {
                Console.WriteLine("bolunmur");
            }

            Console.ReadKey();

        }
    }
}
