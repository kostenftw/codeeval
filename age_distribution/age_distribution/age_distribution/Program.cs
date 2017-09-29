using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace age_distribution
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            string line = Console.ReadLine();

            value = Convert.ToInt32(line);

            if ((value <0) || (value>100))
            {
                Console.WriteLine("This program is for humans");
            }
            else if (value <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (value <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (value <= 11)
            {
                Console.WriteLine("Elementary school");
            }
            else if (value <= 14)
            {
                Console.WriteLine("Middle school");
            }
            else if (value <= 18)
            {
                Console.WriteLine("High school");
            }
            else if (value <= 22)
            {
                Console.WriteLine("College");
            }
            else if (value <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if (value <= 100)
            {
                Console.WriteLine("The Golden Years");
            }


            Console.ReadKey();
        }
    }
}

/*  using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    if (line == 0)
                    {
                        Console.WriteLine("Still in Mama's arms")
                    }
                    // do something with line
                }
                */
