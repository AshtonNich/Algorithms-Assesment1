using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_A1
{
    internal class SelectionSort
    {
        public static void SelSortAscending(int[] array)
        {
            int n = array.Length;
            int steps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                        steps++;
                    }
                }
                int temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }
            Console.WriteLine("Steps taken - " + steps);
        }
        public static void SelSortDescending(int[] array)
        {
            int n = array.Length;
            int steps = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > array[max])
                    {
                        max = j;
                        steps++;
                    }
                }
                int temp = array[max];
                array[max] = array[i];
                array[i] = temp;
            }
            Console.WriteLine("Steps taken - " + steps);
        }
    }
}
