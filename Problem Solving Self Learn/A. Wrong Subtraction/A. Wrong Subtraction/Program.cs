using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Wrong_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int num1 = int.Parse(str[0]);
            int num2 = int.Parse(str[1]);

            for (int i = 0; i < num2; i++)
            {

                if ((num1 % 10) == 0)
                {
                    num1 = num1 / 10;
                }
                else
                {
                    num1--;
                }
            }
            Console.WriteLine(num1);
            //Console.ReadKey();
        }
    }
}
