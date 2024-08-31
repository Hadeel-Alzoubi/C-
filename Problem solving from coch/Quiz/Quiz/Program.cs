using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student(2,2,2);
            Console.WriteLine(std.Yname("hadeel"));
            Console.WriteLine(std.AVG());

            Console.ReadKey();

        }
    }

    public class Student
    {
        string name;
        double fgrade;
        double sgrade;
        double final;
      

        public Student(double fgrade, double sgrade, double final)
        {
            //this.name = name;
            this.fgrade = fgrade;
            this.sgrade = sgrade;
            this.final = final;
        }

        public string Yname(string n)
        {
            name = n;
            return name;
        }
        public double AVG()
        {
            double avg = fgrade + sgrade + final;
            return avg / 3;
        }
    }


}


