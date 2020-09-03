using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Makers
{
    class PinCreator : CharExtractor
    {
        public string setPin(int pinLength)
        {
            return getDigits(pinLength);
        }


    }
}
