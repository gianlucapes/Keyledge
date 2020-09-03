using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Makers
{
    class TextElements
    {

        protected Random extractor = new Random();
        protected string specialCharacters = "!#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        protected string letters = "abcdefghijklmnopqrstuvwxyz";
        protected string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        protected string digits = "0123456789";
        protected string randomChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        protected string prodKeyChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        protected string slash = "-";

    }
}
