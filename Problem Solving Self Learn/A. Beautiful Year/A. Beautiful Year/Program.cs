using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Beautiful_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            while(true) 
            {
                year++;
                if(Convert.ToString(year).Distinct().Count() == 4)
                {
                    break;
                }
            }
            Console.WriteLine(year);
            //Console.ReadLine();
        }
    }
}
