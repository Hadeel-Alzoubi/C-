using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Any String : ");
            string str = Console.ReadLine();
            int size = str.Length;
            Console.WriteLine(str[size-1]);


            ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter Yoyr Name : ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Any String : ");
            string str2 = Console.ReadLine();

            Console.WriteLine(str1 + "  " +str2);

            Console.ReadKey();
        }
    }
}
