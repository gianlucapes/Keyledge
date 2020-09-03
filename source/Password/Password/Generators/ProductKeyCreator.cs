using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password.Makers
{
    class ProductKeyCreator : CharExtractor
    {
        private string prodKey;
        private int l;
        string getRandomProdKey(int a,int b)
        {
            prodKey = null;
            l = prodKeyChars.Length;
            for (int i = 0; i < b; i++)
            {
                prodKey +=getRandomChars(a);
                if (i == (b - 1))
                    break;
                prodKey += slash;
            }
            return prodKey;

        }
        string getCostumizedProdKey(int ch,int uCh,int dg,int grs)
        {
            prodKey = null;
         for (int o=0;o<grs;o++)
            {
                prodKey += getChars(ch);
                prodKey += getUpperChars(uCh);
                prodKey += getDigits(dg);
                if (o == (grs-1))
                    break;
                prodKey += slash;
            }
            return prodKey;
        }
        public string setProdKey(Boolean randomMode, int ch, int uCh, int dg,int members ,int groups)
        {
            if (!randomMode)
                return getCostumizedProdKey(ch, uCh, dg, groups);
            else return getRandomProdKey(members, groups);

        }
    }
}
