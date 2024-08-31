using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string size = Console.ReadLine();
            int n = Convert.ToInt32(size);
            int counter = 0;
            for (int i = 1; counter <= n; i+=2)
            {
                Console.WriteLine(i);
                counter++;
            }
       
            Console.ReadKey();
        }

        
    }
}


//static void Main(string[] args)
//{
//    int x = Convert.ToInt32(Console.ReadLine());
//    int sum = 0;
//    for (int i = 0; i <= x; i++)
//    {
//        sum += i;
//    }
//    Console.WriteLine($"The Sum of Natural Number upto {x} terms : {sum}");
//    Console.ReadKey();
//}
//static void Main(string[] args)
//{
//    int x = 0;
//    int y = Convert.ToInt32(Console.ReadLine());

//    for (int i = 1; i <= 10; i++)
//    {
//        for (int j = 1; j <= y; j++)
//        {
//            x = i * j;
//            Console.Write($"{i} * {j} = {x}" + "    ");
//        }
//        Console.WriteLine();
//    }
//    Console.ReadKey();
//}