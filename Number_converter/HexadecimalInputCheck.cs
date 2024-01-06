using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Number_converter
{
    internal class HexadecimalInputCheck
    {
        public bool Hexinputcheckmethod(string hextext)
        {
            bool hexcommacheck = false;

            if (hextext.Contains(','))
                hexcommacheck = true;

            if ((Regex.IsMatch(hextext, @"[^0-9,A-F,a-f]")) || (hexcommacheck == true))
            {
                MessageBox.Show("nope!" + System.Environment.NewLine + "hexadecimal only", "Wrong input",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation); // wrong data!!!
                return false;
            }
            else
                return true;
        }
    }
}
