using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_A1
{
    internal class DisplayEveryTenthValue
    { 
        public static void DisplayTenthValue(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
