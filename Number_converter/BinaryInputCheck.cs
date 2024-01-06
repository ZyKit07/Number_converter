using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Number_converter
{
    internal class BinaryInputCheck
    {
        public bool Bininputcheckmethod(string bintext)
        {
            bool bincommacheck = false;

            if (bintext.Contains(','))
                bincommacheck = true;

            if ((Regex.IsMatch(bintext, @"[^0-1,s]")) || (bincommacheck == true))
            {
                MessageBox.Show("nope!" + System.Environment.NewLine + "binary only", "Wrong input",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation); // wrong data!!!
                return false;
            }
            else
                return true;
        }
    }
}
