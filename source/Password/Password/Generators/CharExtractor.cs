using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Makers
{
    class CharExtractor : TextElements
    {


        private string extractChars;
        private int l = 0;
        private int randomNumb = 0;
        private string e_Char;
        private string u_Chars;
        private string Digits;
        private string sChars;

        public string getChars(int loop)
        {
            e_Char = null;
            l = letters.Length;
            for (int i = 0; i < loop; i++)
            {
                randomNumb = extractor.Next(1, l);
                e_Char += letters[randomNumb];
            }
            return e_Char;
        }

        protected string getUpperChars(int loop)
        {
            u_Chars = null;
            l = upperLetters.Length;
            for (int i = 0; i < loop; i++)
            {
                randomNumb = extractor.Next(1, l);
                u_Chars += upperLetters[randomNumb];
            }
            return u_Chars;
        }

        protected string getDigits(int loop)
        {
            Digits = null;
            l = digits.Length;
            for (int i = 0; i < loop; i++)
            {
                randomNumb = extractor.Next(1, l);
                Digits += digits[randomNumb];
            }
            return Digits;
        }

        protected string getSpecialChars(int loop)
        {
            sChars = null;
            l = specialCharacters.Length;
            for (int i = 0; i < loop; i++)
            {
                randomNumb = extractor.Next(1, l);
                sChars += specialCharacters[randomNumb];
            }
            return sChars;
        }

        protected string getRandomAllChars(int chars)
        {
            extractChars = null;
            l = randomChars.Length;
            for (int i = 0; i < chars; i++)
            {
                randomNumb = extractor.Next(1, l);
                extractChars += randomChars[randomNumb];
            }
            return extractChars;
        }
        protected string getRandomChars(int chars)
        {
            extractChars = null;
            l = prodKeyChars.Length;
            for (int i = 0; i < chars; i++)
            {
                randomNumb = extractor.Next(1, l);
                extractChars += prodKeyChars[randomNumb];
            }
            return extractChars;
        }

    }
}
