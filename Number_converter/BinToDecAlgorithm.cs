using System;
using System.Collections.Generic;
using System.Text;

namespace Number_converter
{
    internal class BinToDecAlgorithm
    {
        public ulong Bintodecmethod(string bintext)
        {
            ulong decresult = 0;
            int binlength = bintext.Length;

            for (int i = 0; i < binlength; i++)
            {
                if (bintext[i] == '1')               
                    decresult += (ulong)(Math.Pow(2, binlength - (i + 1)));               
            }
            return decresult;
        }
    }
}
