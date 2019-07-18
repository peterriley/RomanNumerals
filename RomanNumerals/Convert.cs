using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Convert
    {
        public static string ConvertToRoman(int wholeNumber, string roman)
        {
            if (wholeNumber >= 1000)
            {
                roman += "M";
                wholeNumber -= 1000;
            } else if (wholeNumber >= 900)
            {
                roman += "CM";
                wholeNumber -= 900;
            } else if (wholeNumber >= 500)
            {
                roman += "D";
                wholeNumber -= 500;
            } else if (wholeNumber >= 400)
            {
                roman += "CD";
                wholeNumber -= 400;
            } else if (wholeNumber >= 100)
            {
                roman += "C";
                wholeNumber -= 100;
            } else if (wholeNumber >= 90)
            {
                roman += "XC";
                wholeNumber -= 90;
            } else if (wholeNumber >= 50)
            {
                roman += "L";
                wholeNumber -= 50;
            } else if (wholeNumber >= 40)
            {
                roman += "XL";
                wholeNumber -= 40;
            } else if (wholeNumber >= 10)
            {
                roman += "X";
                wholeNumber -= 10;
            } else if (wholeNumber == 9)
            {
                roman += "IX";
                wholeNumber -= 9;
            } else if (wholeNumber >= 5)
            {
                roman += "V";
                wholeNumber -= 5;
            } else if (wholeNumber == 4)
            {
                roman += "IV";
                wholeNumber -= 4;
            } else
            {
                roman += "I";
                wholeNumber -= 1;
            }

            // Use recursion to return roman
            return (wholeNumber == 0) ? roman : ConvertToRoman(wholeNumber, roman);
        }

        public static int ConvertFromRoman(string romanNumerals)
        {
            int result = 0;

            for (int i = 0; i < romanNumerals.Length; i++)
            {
                int n1 = NumeralValue(romanNumerals[i]);

                if (i + 1 < romanNumerals.Length)
                {
                    int n2 = NumeralValue(romanNumerals[i + 1]);

                    if (n1 >= n2)
                    {
                        result += n1;
                    } else
                    {
                        result += n2 - n1;
                        i++;
                    }
                } else
                {
                    result += n1;
                    i++;
                }
            }

            return result;
        }

        static int NumeralValue(char nv)
        {
            if (nv == 'I')
                return 1;
            if (nv == 'V')
                return 5;
            if (nv == 'X')
                return 10;
            if (nv == 'L')
                return 50;
            if (nv == 'C')
                return 100;
            if (nv == 'D')
                return 500;
            if (nv == 'M')
                return 1000;
            return -1;
        }
    }
}
