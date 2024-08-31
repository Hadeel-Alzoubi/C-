using System;

namespace CodeForcesSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            long n = Convert.ToInt64(Console.ReadLine());
            long h = Convert.ToInt64(Console.ReadLine());

            long[] num = new long[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt64(Console.ReadLine());

                if (num[i] <= h)
                {
                    sum += 1;
                }
                else
                {
                    sum += 2;
                }
            }
            Console.WriteLine(sum);

            
        }
    }
}
