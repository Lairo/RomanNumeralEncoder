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
            //Console.WriteLine(Solution(1)); // "I"
            //Console.WriteLine(Solution(2)); // "II"
            //Console.WriteLine(Solution(4)); // "IV"
            //Console.WriteLine(Solution(500)); // "D"
            Console.WriteLine(Solution(843));
            //Console.WriteLine(Solution(1000)); // "M"
            //Console.WriteLine(Solution(1899));
            //Console.WriteLine(Solution(1954)); // "MCMLIV"
            //Console.WriteLine(Solution(1990)); // "MCMXC"
            //Console.WriteLine(Solution(2008)); // "MMVIII"
            //Console.WriteLine(Solution(2014)); // "MMXIV"
        }


        /// for or foreach
        /// need to cycle through the each case study or a long ifstatement chain?
        /// if the number is 4 digits then add m for each thousant, then calculate below 1000
        /// is the 1000>number<499? then D for 500
        /// take away 500 intergers from the number and so on
        /// 
        /// while(number>0){
        /// is the number more than 1000? yes -> string add M and [number -1000]
        /// is the number more than 500 yes -> string add C and [number -1000]
        /// }
        ///

        // Symbol Value
        // I          1
        // V          5
        // X          10
        // L          50
        // C          100
        // D          500
        // M          1,000

        public static string Solution(int n)
        {
            int m = n;
            string romanNumeral = "";

            while (m > 0)
            {
                while (m >= 1000)
                {
                    romanNumeral += "M";
                    m = m - 1000;
                }
                if (m < 1000 && m > 899)
                {
                    romanNumeral += "CM";
                    m = m - 900;
                }

                if (m >= 899 || m >= 500)
                {
                    romanNumeral += "D";
                    m = m - 500;
                }

                if (m >= 499 || m > 399)
                {
                    romanNumeral += "CD";
                    m = m - 400;
                }
                while (m > 99)
                {
                    romanNumeral += "C";
                    m = m - 100;
                }

                if (m <= 99 && m > 89)
                {
                    romanNumeral += "XC";
                    m = m - 90;
                }

                if (m >= 89 || m >= 50)
                {
                    romanNumeral += "L";
                    m = m - 50;
                }

                if (m >= 49 || m > 39)
                {
                    romanNumeral += "XL";
                    m = m - 40;
                }
                while (m > 9)
                {
                    romanNumeral += "X";
                    m = m - 10;
                }

                if (m == 9)
                {
                    romanNumeral += "IX";
                    m = m - 9;
                }

                if (m >= 8 || m >= 5)
                {
                    romanNumeral += "V";
                    m = m - 5;
                }

                if (m >= 4 && m > 3)
                {
                    romanNumeral += "IV";
                    m = m - 10;
                }
                while (m > 0)
                {
                    romanNumeral += "I";
                    m = m - 1;
                }

            }

            return romanNumeral;
        }

    }
}
