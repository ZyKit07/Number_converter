using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Number_converter
{
    internal class HexToDecAlgorithm
    {
        public ulong Hextodecmethod(string hextext)
        {
            string mask = "ABCDEF";
            string scanchar = "0";

            int hexnumberlength = hextext.Length;
            ulong decresult = 0;

            for (int i = hexnumberlength - 1; i > 0; i--)
            {
                scanchar = Convert.ToString(hextext[(hexnumberlength - 1) - i]);

                if ((Regex.IsMatch(scanchar, @"[^0-9,s]") == false))                
                    decresult += (Convert.ToUInt64(scanchar) * (ulong)(Math.Pow(16, i)));                
                else
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Convert.ToString(mask[j]) == scanchar)
                            decresult += ((ulong)(j + 10) * (ulong)(Math.Pow(16, i)));
                    }
                }
            }
            scanchar = Convert.ToString(hextext[hexnumberlength - 1]);

            if ((Regex.IsMatch(scanchar, @"[^0-9,s]") == false))
                decresult += Convert.ToUInt64(scanchar);
            else
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Convert.ToString(mask[j]) == scanchar)
                        decresult += ((ulong)(j + 10));
                }
            }
            return decresult;
        }
    }
}
