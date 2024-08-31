using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Word
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int upper = 0;
            int lower = 0;
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i])) 
                {
                    upper += 1;
                }
                else if (char.IsLower(word[i])) 
                { 
                    lower += 1;
                }
            }
            if (lower >= upper)
            {
                Console.WriteLine(word.ToLower());
            }
                
            else { 
                Console.WriteLine(word.ToUpper());
            }

            

           Console.ReadKey();
        }
    }
}
