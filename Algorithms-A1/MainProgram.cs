using Algorithms_A1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            //string Direct = @"Files\Net_1_256.txt";
            //foreach (string line in TxtToArray.ReadTxt(Direct))
            //{
            //Console.WriteLine(line);
            //}
            Console.WriteLine("Sorting Algorithms");
            Console.WriteLine("All file names - ");
            Console.WriteLine("2048");
            Console.WriteLine("256");
            Console.WriteLine("2048-2");
            Console.WriteLine("256-2");
            Console.WriteLine("2048-3");
            Console.WriteLine("256-3");
            Console.WriteLine("What file would you like to sort? - ");
            string userFile = Console.ReadLine();
            if (userFile == "2048")
            {
                string Direct = @"Files\Net_1_2048.txt";
                foreach (string line in TxtToArray.ReadTxt(Direct))
                {
                    Console.WriteLine(line);
                }
            }
            else if (userFile == "256")
            {
                string Direct = @"Files\Net_1_256.txt";
                foreach (string line in TxtToArray.ReadTxt(Direct))
                {
                    Console.WriteLine(line);
                }
            }
            else if (userFile == "2048-2")
            {
                string Direct = @"Files\Net_2_2048.txt";
                foreach (string line in TxtToArray.ReadTxt(Direct))
                {
                    Console.WriteLine(line);
                }
            }
            else if (userFile == "256-2")
            {
                string Direct = @"Files\Net_2_256.txt";
                foreach (string line in TxtToArray.ReadTxt(Direct))
                {
                    Console.WriteLine(line);
                }
            }
            else if (userFile == "2048-3")
            {
                string Direct = @"Files\Net_3_2048.txt";
                foreach (string line in TxtToArray.ReadTxt(Direct))
                {
                    Console.WriteLine(line);
                }
            }
            else if (userFile == "256-3")
            {
                string Direct = @"Files\Net_3_256.txt";
                foreach (string line in TxtToArray.ReadTxt(Direct))
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Invalid file name");
            }

        }

    }
}