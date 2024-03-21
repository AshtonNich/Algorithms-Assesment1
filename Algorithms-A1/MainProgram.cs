using Algorithms_A1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(("").PadRight(24, '-') + "\nSorting Algorithms\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("All file names - \n" + "2048 \n" + "256 \n" + "2048-2 \n" + "256-2 \n" + "2048-3 \n" + "256-3");
            Console.WriteLine("What file would you like to sort? - \n" + ("").PadRight(24, '-'));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string userFile = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (userFile == "2048")
            {
                string Direct = @"Files\Net_1_2048.txt";
                Console.WriteLine("You are reading file " + Direct + "\nWhat sort would you like to use?\n" + "Linear Sort\n" + "Selection Sort\n" + ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userSort = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (userSort == "Linear")
                {
                    string[] array = (TxtToArray.ReadTxt(Direct));
                    int[] lines = Array.ConvertAll(array, int.Parse);
                    LinearSort.LinSort(lines);
                    Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                    foreach (int line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Linear sort done!\n" + ("").PadRight(24, '-'));

                }
                else if (userSort == "Selection")
                {

                }
            }
            else if (userFile == "256")
            {

            }

        }

    }
}