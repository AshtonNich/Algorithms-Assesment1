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
            Console.WriteLine("\nSort and Search Algorithms\n" + ("").PadRight(24, '-'));
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
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Ascending)\n" + ("").PadRight(24, '-'));

                    }
                    else if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Descending)\n" + ("").PadRight(24, '-'));


                    }
                }
                else if (userSort == "Selection")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Descending)\n" + ("").PadRight(24, '-'));
                    }
                    else if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Ascending)\n" + ("").PadRight(24, '-'));
                    }
                    else
                    {
                        Console.WriteLine("Invalid sort\n" + ("").PadRight(24, '-'));
                    }
                    Console.WriteLine("Would you like to search for a value in the file/txt?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userSearch = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userSearch == "Yes")
                    {
                        Console.WriteLine("What value would you like to search for?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string userValue = Console.ReadLine();
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSearch.LinSearch(lines, Convert.ToInt32(userValue));
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                    else if (userSearch == "No")
                    {
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                }
            }
            if (userFile == "256")
            {
                string Direct = @"Files\Net_1_256.txt";
                Console.WriteLine("You are reading file " + Direct + "\nWhat sort would you like to use?\n" + "Linear Sort\n" + "Selection Sort\n" + ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userSort = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (userSort == "Linear")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Ascending)\n" + ("").PadRight(24, '-'));

                    }
                    else if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Descending)\n" + ("").PadRight(24, '-'));


                    }
                }
                else if (userSort == "Selection")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Descending)\n" + ("").PadRight(24, '-'));
                    }
                    else if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Ascending)\n" + ("").PadRight(24, '-'));
                    }
                    else
                    {
                        Console.WriteLine("Invalid sort\n" + ("").PadRight(24, '-'));
                    }
                    Console.WriteLine("Would you like to search for a value in the file/txt?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userSearch = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userSearch == "Yes")
                    {
                        Console.WriteLine("What value would you like to search for?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string userValue = Console.ReadLine();
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSearch.LinSearch(lines, Convert.ToInt32(userValue));
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                    else if (userSearch == "No")
                    {
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                }

            }
            if (userFile == "2048-2")
            {
                string Direct = @"Files\Net_2_2048.txt";
                Console.WriteLine("You are reading file " + Direct + "\nWhat sort would you like to use?\n" + "Linear Sort\n" + "Selection Sort\n" + ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userSort = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (userSort == "Linear")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Ascending)\n" + ("").PadRight(24, '-'));

                    }
                    else if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Descending)\n" + ("").PadRight(24, '-'));


                    }
                }
                else if (userSort == "Selection")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Descending)\n" + ("").PadRight(24, '-'));
                    }
                    else if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Ascending)\n" + ("").PadRight(24, '-'));
                    }
                    else
                    {
                        Console.WriteLine("Invalid sort\n" + ("").PadRight(24, '-'));
                    }
                    Console.WriteLine("Would you like to search for a value in the file/txt?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userSearch = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userSearch == "Yes")
                    {
                        Console.WriteLine("What value would you like to search for?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string userValue = Console.ReadLine();
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSearch.LinSearch(lines, Convert.ToInt32(userValue));
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                    else if (userSearch == "No")
                    {
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                }

            }
            if (userFile == "256-2")
            {
                string Direct = @"Files\Net_2_256.txt";
                Console.WriteLine("You are reading file " + Direct + "\nWhat sort would you like to use?\n" + "Linear Sort\n" + "Selection Sort\n" + ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userSort = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (userSort == "Linear")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Ascending)\n" + ("").PadRight(24, '-'));

                    }
                    else if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Descending)\n" + ("").PadRight(24, '-'));


                    }
                }
                else if (userSort == "Selection")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Descending)\n" + ("").PadRight(24, '-'));
                    }
                    else if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Ascending)\n" + ("").PadRight(24, '-'));
                    }
                    else
                    {
                        Console.WriteLine("Invalid sort\n" + ("").PadRight(24, '-'));
                    }
                    Console.WriteLine("Would you like to search for a value in the file/txt?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userSearch = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userSearch == "Yes")
                    {
                        Console.WriteLine("What value would you like to search for?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string userValue = Console.ReadLine();
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSearch.LinSearch(lines, Convert.ToInt32(userValue));
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                    else if (userSearch == "No")
                    {
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                }

            }
            if (userFile == "2048-3")
            {
                string Direct = @"Files\Net_3_2048.txt";
                Console.WriteLine("You are reading file " + Direct + "\nWhat sort would you like to use?\n" + "Linear Sort\n" + "Selection Sort\n" + ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userSort = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (userSort == "Linear")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Ascending)\n" + ("").PadRight(24, '-'));

                    }
                    else if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Descending)\n" + ("").PadRight(24, '-'));


                    }
                }
                else if (userSort == "Selection")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Descending)\n" + ("").PadRight(24, '-'));
                    }
                    else if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Ascending)\n" + ("").PadRight(24, '-'));
                    }
                    else
                    {
                        Console.WriteLine("Invalid sort\n" + ("").PadRight(24, '-'));
                    }
                    Console.WriteLine("Would you like to search for a value in the file/txt?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userSearch = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userSearch == "Yes")
                    {
                        Console.WriteLine("What value would you like to search for?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string userValue = Console.ReadLine();
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSearch.LinSearch(lines, Convert.ToInt32(userValue));
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                    else if (userSearch == "No")
                    {
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                }

            }
            if (userFile == "256-3")
            {
                string Direct = @"Files\Net_3_256.txt";
                Console.WriteLine("You are reading file " + Direct + "\nWhat sort would you like to use?\n" + "Linear Sort\n" + "Selection Sort\n" + ("").PadRight(24, '-'));
                Console.ForegroundColor = ConsoleColor.Yellow;
                string userSort = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (userSort == "Linear")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Ascending)\n" + ("").PadRight(24, '-'));

                    }
                    else if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSort.LinSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Linear sort done!(Descending)\n" + ("").PadRight(24, '-'));


                    }
                }
                else if (userSort == "Selection")
                {
                    Console.WriteLine("Sort ascending or descending?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userOrder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userOrder == "Descending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortDescending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Descending)\n" + ("").PadRight(24, '-'));
                    }
                    else if (userOrder == "Ascending")
                    {
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        SelectionSort.SelSortAscending(lines);
                        Console.WriteLine("Sorted list here\n" + ("").PadRight(24, '-'));
                        foreach (int line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("Selection sort done!(Ascending)\n" + ("").PadRight(24, '-'));
                    }
                    else
                    {
                        Console.WriteLine("Invalid sort\n" + ("").PadRight(24, '-'));
                    }
                    Console.WriteLine("Would you like to search for a value in the file/txt?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string userSearch = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (userSearch == "Yes")
                    {
                        Console.WriteLine("What value would you like to search for?");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string userValue = Console.ReadLine();
                        string[] array = (TxtToArray.ReadTxt(Direct));
                        int[] lines = Array.ConvertAll(array, int.Parse);
                        LinearSearch.LinSearch(lines, Convert.ToInt32(userValue));
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                    else if (userSearch == "No")
                    {
                        Console.WriteLine(("").PadRight(24, '-'));
                    }
                }

            }
        }
    }
}