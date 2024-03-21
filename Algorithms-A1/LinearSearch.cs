using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_A1
{
    internal class LinearSearch
    {
        public static void LinSearch(int[] array, int x)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine("Element found at index " + i);
                    return;
                }
            }
            Console.WriteLine("Element not found");
        }
    }
}
