using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Number_converter
{
    internal class DecToBinAlgorithm
    {
        public string Dectobinmethod(ulong decnumber)
        {
            string BINRESULT = "0";
            int stepen = 1;

            System.Numerics.BigInteger difference = 0;
            do
            {
                stepen++;

                if ((decnumber > 1) && stepen <= 64)               
                    BINRESULT += "0";
            }
            while ((System.Numerics.BigInteger.Pow(2, stepen)) <= decnumber);

            StringBuilder sb = new StringBuilder(BINRESULT);
            sb[0] = '1';
            BINRESULT = sb.ToString();

            stepen--;
            difference = decnumber - System.Numerics.BigInteger.Pow(2, stepen);

            for (int i = stepen; i > 0; i--)
            {
                if (System.Numerics.BigInteger.Pow(2, i - 1) <= difference)
                {
                    StringBuilder sb3 = new StringBuilder(BINRESULT);
                    sb3[BINRESULT.Length - i] = '1';
                    BINRESULT = sb3.ToString();
                    difference -= (System.Numerics.BigInteger.Pow(2, i - 1));
                }
                else
                {
                    StringBuilder sb3 = new StringBuilder(BINRESULT);
                    sb3[BINRESULT.Length - i] = '0';
                    BINRESULT = sb3.ToString();

                    if (decnumber == 1)                    
                        BINRESULT = "1";                   
                }
            }
            if (decnumber == 0)            
                BINRESULT = "0";
            
            return BINRESULT;
        }
    }
}
