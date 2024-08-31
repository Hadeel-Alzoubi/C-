using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAnd_Write
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            
            // Write to file
            WriteToFile(filePath);

            // Read from file
            ReadFromFile(filePath);

            Console.ReadKey();
        }

        static void WriteToFile(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("Hello, world!");
                    sw.WriteLine("This is a new line.");
                }
                Console.WriteLine("File written successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while writing to the file:");
                Console.WriteLine(e.Message);
            }
        }

        static void ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while reading the file:");
                Console.WriteLine(e.Message);
            }
        }


    }
}
