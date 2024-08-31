using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var str  = new string[6] ;

            //Console.WriteLine("Please Enter Your Name");
            //string name = Console.ReadLine();
            //str[0] = name ;
            //string name1 = Console.ReadLine();
            //str[1] = name1;
            //string name2 = Console.ReadLine();
            //str[2] = name2;
            //string name3 = Console.ReadLine();
            //str[3] = name3;
            //string name4 = Console.ReadLine();
            //str[4] = name4;
            //string name5 = Console.ReadLine();
            //str[5] = name5;

            //Array.Sort(str) ;
            //Console.WriteLine(str[0]);
            //Console.WriteLine(str[1]);
            //Console.WriteLine(str[2]);
            //Console.WriteLine(str[3]);
            //Console.WriteLine(str[4]);
            //Console.WriteLine(str[5]);

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a >= b)
            {
                //for (int i = 0; i < a; i++)
                //{

                //}

                b = b * 3 + b;
                a = a * a;
            }
            Console.WriteLine(b);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
