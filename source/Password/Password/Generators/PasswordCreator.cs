using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Makers
{
    class PasswordCreator : CharExtractor
    {


        private int tot_chars = 0;

        string getCostumizedPassword(int chr, int uChr, int d, int sC)
        {
            tot_chars = chr + uChr + d + sC;
            if (tot_chars % 2 == 0)
                return getChars(chr) + getUpperChars(uChr) + getDigits(d) + getSpecialChars(sC);
            if (tot_chars % 2 == 1)
                return getUpperChars(uChr) + getChars(chr) + getSpecialChars(sC) + getDigits(d);
            else return getSpecialChars(sC) + getUpperChars(uChr) + getChars(chr) + getDigits(d);
        }


        string getRandomPassword(int t_chars)
        { 
                return getRandomAllChars(t_chars);
        }
        
        public string setPassword(Boolean random, int totalChars = 1, int chr = 1, int uChr = 1, int d = 1, int sC = 1)
        {
            
            if (!random)
                return getCostumizedPassword(chr, uChr, d, sC);
            else return getRandomPassword(totalChars);
        }

    }
}
