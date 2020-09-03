using Password.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password
{
    public partial class Keyledge : Form
    {
        CharsCounter cc = new CharsCounter();
        Functions function = new Functions();
       
        /// <summary>
        /// reset radio button
        /// </summary>
        void unCheckedRadioButton() 
        {
           
            radioProdKey.Checked = false;
            radioPin.Checked = false;
            radioCostumized.Checked = false;
            radioRandom.Checked = false;
            radioPssword.Checked = true;
        }
        void resetControllsValue()
        {
            ch1.Value = 1;
            ch2.Value = 1;
            chSpecial.Value = 1;
            charsGroup.Value = 1;
            digitsChars.Value = 1;
            groups.Value = 1;
            chSpecial.Value = 1;
            
        }
        void defaultChangeRadioValue()
        {
            radioRandom.Checked = false;
            radioCostumized.Checked = false;
        }
     

        /// <summary>
        /// function for cancel button it reset all values 
        /// </summary>
        void resetValue()
         {
            psswordBox.ResetText();
            prodKeyBox.ResetText();
            pinBox.ResetText();
            counterBox.ResetText();
            counterBox.ResetText();
            resetControllsValue();
            unCheckedRadioButton();
         }
        void startState()
        {
            ch1.Controls[0].Enabled = false;
            ch2.Controls[0].Enabled = false;
            chSpecial.Controls[0].Enabled = false;
            digitsChars.Controls[0].Enabled = false;
            groups.Controls[0].Enabled = false;
            charsGroup.Controls[0].Enabled = false;
            counterBox.Enabled = false;
        }
        /// <summary>
        /// This two function enabled and disabled radioButton mode for genereting pin 
        /// </summary>
        void disabledAllModes()
        {
            radioRandom.Enabled = false;
            radioCostumized.Enabled = false;
        }
        void enabledAllModes()
        {
            radioRandom.Enabled = true;
            radioCostumized.Enabled = true;
        }
        /// <summary>
        /// function for enabled passwords controls
        /// </summary>
        void randomPassword()
        {
            ch1.Controls[0].Enabled = false;
            ch2.Controls[0].Enabled = false;
            chSpecial.Controls[0].Enabled = false;
            digitsChars.Controls[0].Enabled = false;
            groups.Controls[0].Enabled = false;
            charsGroup.Controls[0].Enabled = false;
            counterBox.Enabled = true;

        }
        void costumizedPassword()
        {
            ch1.Controls[0].Enabled = true;
            ch2.Controls[0].Enabled = true;
            chSpecial.Controls[0].Enabled = true;
            digitsChars.Controls[0].Enabled = true;
            groups.Controls[0].Enabled = false;
            charsGroup.Controls[0].Enabled = false;
            counterBox.Enabled = false;

        }
     
        void passwordChecked()
        {
           
            if (randomModeSelected() == true)
                randomPassword();
            else
                costumizedPassword();
        }
       
        /// <summary>
        /// function for pin radio button
        /// </summary>
        void pinChecked() 
        {
                disabledAllModes();
                startState();
                digitsChars.Controls[0].Enabled = true;
        }
        /// <summary>
        /// all function for enabled prodKey controls
        /// </summary>
        void costumizedProdKey()
        {
            chSpecial.Controls[0].Enabled = false;
            ch1.Controls[0].Enabled = true;
            ch2.Controls[0].Enabled = true;
            digitsChars.Controls[0].Enabled = true;
            groups.Controls[0].Enabled = true;
            charsGroup.Controls[0].Enabled = false;
        }
        void randomProductKey()
        {
            chSpecial.Controls[0].Enabled = false;
            ch1.Controls[0].Enabled = false;
            ch2.Controls[0].Enabled = false;
            digitsChars.Controls[0].Enabled = false;
            groups.Controls[0].Enabled = true;
            charsGroup.Controls[0].Enabled = true;
        }
        
        void productKeyChecked() 
        {
           
            if (randomModeSelected() == true)
                randomProductKey();
            else
                costumizedProdKey();
        }
        
        /// <summary>
        /// check if any radio button are checked
        /// </summary>
        /// <returns>true if a radio button is checked</returns>
        Boolean radioButtonChecked()
        {
            if (radioPssword.Checked == true || radioPin.Checked == true || radioProdKey.Checked == true)
                return true;
            else return false;
        }
      

        void genereteButton()
        {
            
            if (radioButtonChecked() == true)
            {
                if (radioPssword.Checked == true)
                {
                    try
                    {
                        psswordBox.AppendText(function.writePassword(randomModeSelected(), counterBox.Text, ch1.Value.ToString(), ch2.Value.ToString(), digitsChars.Value.ToString(), chSpecial.Value.ToString()));
                    }
                    catch (Exception)
                    {
                        function.showWarningInvalidValue();
                    }
                }
                
                     
                   
                else
                    if (radioProdKey.Checked == true)
                {
                    try
                    { prodKeyBox.AppendText(function.writeProductKey(randomModeSelected(), ch1.Value.ToString(), ch2.Value.ToString(), digitsChars.Value.ToString(), charsGroup.Value.ToString(), groups.Value.ToString())); 
                    }
                    catch(Exception)
                    { 
                    
                    }
                }
                
                  
                
                    
                else
                    if (radioPin.Checked == true) 
                {
                    try
                    {
                        pinBox.AppendText(function.writePin(digitsChars.Value.ToString()));
                    }

                    catch (Exception)
                    {

                    }
                }
                    

                else function.showWarningMessageSystemError();
            }
               
          
        }
        
 
        Boolean randomModeSelected()
        {
            if (radioRandom.Checked == true)
                return true;
            else return false;
        }
        string getEachChars()
        {
            if (radioPssword.Checked == true)
                return cc.countPasswordChars(ch1.Value.ToString(), ch2.Value.ToString(), digitsChars.Value.ToString(), chSpecial.Value.ToString());
            else
            if (radioProdKey.Checked == true)
                return cc.countProductKey(ch1.Value.ToString(), ch2.Value.ToString(), digitsChars.Value.ToString());
            else
                if (radioPin.Checked == true)
                return cc.countPinChars(digitsChars.Value.ToString());
            else return String.Empty;
        }
        
        void setTotalChars()
        {
            counterBox.ResetText();
            counterBox.AppendText(getEachChars());
        }
        string selectedText()
        {
            if (psswordBox.SelectionLength > 0)
                return psswordBox.Text;
            if (prodKeyBox.SelectionLength > 0)
                return prodKeyBox.Text;
            if (pinBox.SelectionLength > 0)
                return pinBox.Text;
            else
                return String.Empty;
        }
        /// <summary>
        /// copy password,pin and prodKey
        /// </summary>
        void copyTextFunction()
        {
            try
            {
                Clipboard.SetText(selectedText());
            }
            catch (Exception)
            {
                function.showWarinigAnyElementMake();
            }
        }
        public Keyledge()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            enabledAllModes();
            resetValue();
        }

        private void radioPssword_CheckedChanged(object sender, EventArgs e)
        {
            counterBox.ResetText();
            enabledAllModes();
            defaultChangeRadioValue();
            resetControllsValue();


        }

        private void radioPin_CheckedChanged(object sender, EventArgs e)
        {
            counterBox.ResetText();
            defaultChangeRadioValue();
            pinChecked();
            resetControllsValue();

        }

        private void radioProdKey_CheckedChanged(object sender, EventArgs e)
        {
            counterBox.ResetText();
            enabledAllModes();
            defaultChangeRadioValue();
            resetControllsValue();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startState();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            copyTextFunction();
           


        }

        private void radioRandom_CheckedChanged(object sender, EventArgs e)
        {
            resetControllsValue();
            counterBox.ResetText();
            if (radioPssword.Checked == true)
                passwordChecked();
            if (radioProdKey.Checked == true)
                productKeyChecked();
            
        }

        private void radioCustomized_CheckedChanged(object sender, EventArgs e)
        {
            resetControllsValue();
            counterBox.ResetText();
            if (radioPssword.Checked == true)
                passwordChecked();
            if (radioProdKey.Checked == true)
                productKeyChecked();

        }

        private void ch1_ValueChanged(object sender, EventArgs e)
        {
            if(! randomModeSelected())
            setTotalChars();
        }

        private void ch2_ValueChanged(object sender, EventArgs e)
        {
            if (!randomModeSelected())
                setTotalChars();
        }

        private void digitsChars_ValueChanged(object sender, EventArgs e)
        {
            if (!randomModeSelected())
                setTotalChars();
        }

        private void chSpecial_ValueChanged(object sender, EventArgs e)
        {
            if (!randomModeSelected())
                setTotalChars();
        }

        private void charsGroup_ValueChanged(object sender, EventArgs e)
        {
            if (!randomModeSelected())
                setTotalChars();
        }

        private void groups_ValueChanged(object sender, EventArgs e)
        {
            if (!randomModeSelected())
                setTotalChars();
        }

        private void generate_Click(object sender, EventArgs e)
        {
         
            if (radioRandom.Checked == false && radioCostumized.Checked == false && radioPin.Checked==false)
                function.showWarningMessageAnyMode();
         
                
            if (cc.numberNotValid(counterBox.Text))
                function.showWarningNumberValue();
               
            
               
         else
                genereteButton();
            
              
           
        }
    }
}
