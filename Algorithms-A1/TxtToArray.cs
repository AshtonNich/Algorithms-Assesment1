using System;
using System.IO;

namespace Algorithms_A1
{
    internal class TxtToArray
    {
        public static string[] ReadTxt(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return lines;
        }
    }
}
