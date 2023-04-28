using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralEncoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(1000));

            Console.WriteLine(Solution(1)); // "I"
            Console.WriteLine(Solution(2)); // "II"
            Console.WriteLine(Solution(4)); // "IV"
            Console.WriteLine(Solution(500)); // "D"
            Console.WriteLine(Solution(1000)); // "M"
            Console.WriteLine(Solution(1954)); // "MCMLIV"
            Console.WriteLine(Solution(1990)); // "MCMXC"
            Console.WriteLine(Solution(2008)); // "MMVIII"
            Console.WriteLine(Solution(2014)); // "MMXIV"



        }
        public static string Solution(int n)
        {
            throw new NotImplementedException();
        }

    }
}
