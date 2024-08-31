using System;

namespace A.Bear_and_Big_Brother
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Limak = Convert.ToInt32(Console.ReadLine());
            int Bob = Convert.ToInt32(Console.ReadLine());
            int counter = 0;


            for (int i = 0; Limak <= Bob; i++)
            {
                Bob  *= 2;
                Limak *= 3;
                counter ++;
            }

            Console.WriteLine(counter);

           //Console.ReadKey();

        }
    }
}
