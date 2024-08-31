using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to calculate the factorial of a given number.
            Console.WriteLine("Please Enter Number To the Factorial Of It : ");
            int number = Convert.ToInt32(Console.ReadLine());
            number *= number;
            Console.WriteLine(number);

            //2- Write a program in C# Sharp to display the n terms of even natural number and their sum.

            Console.WriteLine("Please Enter Number To Sum The Even Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number1; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    //Console.WriteLine(i);

                }
            }
            Console.WriteLine(sum);

            //3- Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.

            Console.WriteLine("Please Enter Number in  1 +11 + 111 + 1111 + .. n terms. : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0;
            for (int i = 0; i < number2; i++)
            {
                if (i % 2 != 0)
                {
                    sum1 += i;
                }

            }
            Console.WriteLine(sum1);

            //4- Write a C# Sharp program to determine whether a given number is prime or not.
            Console.WriteLine("Enter Number To Determine Wether is a Prime Or not : ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool result = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }

            //5- Write a program that displays the second largest integer among five integers

            Console.WriteLine("Enter 5 Number : ");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine(arr[arr.Length - 2]);

            //6 - Write a code to find duplicate values in a given array

            Console.WriteLine("Enter Length Of Array : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr0 = { 1, 1, 1, 2, 2, 2, 2, 4 };
            int count = 0;
            for (int j = 0; j < arr0.Length; j++)
            {
                arr0[j] = Convert.ToInt32(Console.ReadLine());
                for (int k = j + 1; k < arr0.Length; k++)
                {


                    if (arr0[j] == arr0[k])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(arr0[j]);
                }
                count = 0;
            }
            //Console.WriteLine("Enter Length Of Array : ");
            //int len = Convert.ToInt32(Console.ReadLine());
            //int[] arr0 = new int[len];
            //int temp = arr0[0];
            //int sum0 = 0;
            ////int temp0;
            //for (int i = 0; i < len; i++)
            //{
            //    arr0[i] = Convert.ToInt32(Console.ReadLine());
            //    if (arr0[i] == temp)
            //    {
            //        sum0++;

            //    }
            //}
            //Console.WriteLine(temp);
            //Console.WriteLine(sum0);
            Console.ReadKey();
        }
    }
}
