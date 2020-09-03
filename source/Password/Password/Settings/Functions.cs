using Password.Makers;
using Password.TextWarning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Settings
{
    class Functions : MessageText
    {
        PasswordCreator pssCreator = new PasswordCreator();
        PinCreator pinCreator = new PinCreator();
        ProductKeyCreator pkCreator = new ProductKeyCreator();
     
      public string writePassword(Boolean randomMode,string t_Ch,string ch,string uCh,string dig,string sCh)
        {
          
                
                int tCh = Convert.ToInt32(t_Ch);
                if (tCh < 0 || tCh > 100)
                tCh = 0;
                int CH = Convert.ToInt32(ch);
                int UCH = Convert.ToInt32(uCh);
                int DIG = Convert.ToInt32(dig);
                int SCH = Convert.ToInt32(sCh);
                return pssCreator.setPassword(randomMode, tCh, CH, UCH, DIG, SCH);
                
        }
        public string writeProductKey(Boolean randomMode,string ch, string uCh, string dg, string m,string g)
        {
            int a = Convert.ToInt32(ch);
            int b = Convert.ToInt32(uCh);
            int c = Convert.ToInt32(dg);
            int d = Convert.ToInt32(m);
            int e = Convert.ToInt32(g);
            return pkCreator.setProdKey(randomMode,a,b,c,d,e);
       
        }
        public string copyValueGenerated(string value,string value1,string value2)
        {

            if (!String.IsNullOrEmpty(value))
                return value;
            else
            if (!String.IsNullOrEmpty(value1))
                return value1;
            else
                if (!String.IsNullOrEmpty(value2))
                return value2;
            return String.Empty;
        }
        public string writePin(string totDigits)
        {
            int t_Digits = Convert.ToInt32(totDigits);
            return pinCreator.setPin(t_Digits);
        }
    
       public void showWarningMessageAnyMode()
        {
            MessageBox.Show(WarningMessage[1], TitleMessage[0], MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }
        public void showWarningMessageSystemError()
        {
            MessageBox.Show(WarningMessage[0], TitleMessage[1], MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }
        public void showWarningInvalidValue()
        {
            MessageBox.Show(WarningMessage[2], TitleMessage[0], MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }
        public void showWarinigAnyElementMake()
        {
            MessageBox.Show(WarningMessage[3], TitleMessage[0], MessageBoxButtons.OK,
              MessageBoxIcon.Exclamation,
              MessageBoxDefaultButton.Button1);
        }
       public void showWarningNumberValue()
        {
            MessageBox.Show(WarningMessage[5], TitleMessage[0], MessageBoxButtons.OK,
              MessageBoxIcon.Exclamation,
              MessageBoxDefaultButton.Button1);
        }
    }
}
