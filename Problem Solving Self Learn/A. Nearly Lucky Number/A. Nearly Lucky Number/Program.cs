using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Nearly_Lucky_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = Convert.ToInt64(Console.ReadLine());
            string num = Convert.ToString(number);
            int counter = 0;
            foreach (int i in num)
            {
                if (i == '4' || i == '7')
                {
                    counter++;
                }
            }
            if (counter == 4 | counter == 7)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
           

            Console.ReadKey();
            
        }
    }
}
