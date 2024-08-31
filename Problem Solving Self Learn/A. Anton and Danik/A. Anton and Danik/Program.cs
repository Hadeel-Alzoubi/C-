using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Anton_and_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counterA = 0;
            int counterD = 0;
            int number = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();

            for (int i = 0; i < number; i++) 
            {
                if (name[i] == 'A')
                {
                    counterA++;
                }
                else if (name[i] == 'D')
                {
                    counterD++;
                }
            }
            if (counterA > counterD) 
            {
                Console.WriteLine("Anton");
            }
            else if (counterA == counterD)
            {
                Console.WriteLine("Friendship");
            }
            else 
            {
                Console.WriteLine("Danik");
            }

            //Console.ReadLine();
        }
    }
}
