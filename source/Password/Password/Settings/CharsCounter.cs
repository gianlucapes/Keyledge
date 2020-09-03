using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Settings
{
    class CharsCounter
    {
        private string total_Chars;
        private int _a, _b, _c, _d,_e,_f;
        private int value = 0;
         int convertNumericUpDownValues(string a)
        {
            int A = Convert.ToInt32(a);
            return A;
        }
      
        public string countPasswordChars(string chars,string chars2,string sChars,string digits)
        {
            _a = convertNumericUpDownValues(chars);
            _b = convertNumericUpDownValues(chars2);
            _c = convertNumericUpDownValues(sChars);
            _d = convertNumericUpDownValues(digits);
            return total_Chars = Convert.ToString(_a + _b + _c + _d); ;
        }
        public string countProductKey(string chars, string chars2, string digits)
        {
            _e = convertNumericUpDownValues(chars);
            _f = convertNumericUpDownValues(chars2);
            _a = convertNumericUpDownValues(digits);
            return total_Chars = Convert.ToString(_e + _f +_a);
        }

        public string countPinChars(string digits)
        {
            _a = convertNumericUpDownValues(digits);
            return total_Chars = Convert.ToString(_a);
        }
      
        public Boolean numberNotValid(string numb)
        {
            try
            {
                value = Convert.ToInt32(numb);
            }
            catch
            {
                value = 1;
            }
           
                if ( value<=0 || value > 100)
                    return true;

            return false;
        }
    }
}
