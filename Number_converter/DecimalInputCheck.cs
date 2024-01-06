using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Number_converter
{
    internal class DecimalInputCheck
    {
        public bool Decinputcheckmethod(string dectext)
        {
            bool deccommacheck = false;

            if (dectext.Contains(','))
                deccommacheck = true;

            if ((Regex.IsMatch(dectext, @"[^0-9, ,s]")) || (deccommacheck == true))
            {
                MessageBox.Show("nope!" + System.Environment.NewLine + "decimal only", "Wrong input",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation); // wrong data!!!
                return false;
            }
            else
                return true;
        }
    }
}
