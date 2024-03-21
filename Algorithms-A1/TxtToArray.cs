using System;
using System.IO;

namespace Algorithms_A1
{
    internal class TxtToArray
    {
        public static string[] ReadTxt(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines;
        }
    }
}
