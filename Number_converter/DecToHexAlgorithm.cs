using System;
using System.Collections.Generic;
using System.Text;

namespace Number_converter
{
    internal class DecToHexAlgorithm
    {
        public string Dectohexmethod(ulong decnumber)
        {
            string mask = "ABCDEF";
            string HEXRESULT = "0";

            int stepen = 1;
            int count = 0;

            System.Numerics.BigInteger difference = 0;
            System.Numerics.BigInteger hexsum = 0;

                if (decnumber <= 15)
                {
                    int tempnumber = (int)(decnumber);
                    if (tempnumber <= 9)
                        HEXRESULT = Convert.ToString(tempnumber);
                    else
                        HEXRESULT = Convert.ToString(mask[tempnumber - 10]);
                }
                else
                {
                    for (int i = 1; (System.Numerics.BigInteger.Pow(16, i)) <= decnumber; i++)
                    {
                        HEXRESULT += "0";
                        difference = decnumber;
                        stepen = i;
                    }
                    for (int i = stepen; i > 0; i--)
                    {
                        for (count = 1; (count * (System.Numerics.BigInteger.Pow(16, i)) <= difference); count++)
                        {
                            if (count <= 9)
                            {
                                string countstring = Convert.ToString(count);
                                StringBuilder SB = new StringBuilder(HEXRESULT);
                                SB[(HEXRESULT.Length - 1) - i] = countstring[0];
                                HEXRESULT = SB.ToString();
                            }
                            else
                            {
                                StringBuilder SB = new StringBuilder(HEXRESULT);
                                SB[(HEXRESULT.Length - 1) - i] = mask[count - 10];
                                HEXRESULT = SB.ToString();
                            }
                        }
                        hexsum += ((count - 1) * (System.Numerics.BigInteger.Pow(16, i)));
                        difference = decnumber - hexsum;
                    }
                    if (difference <= 9)
                    {
                        int tempnumber = (int)(difference);
                        string lastchar = Convert.ToString(tempnumber);
                        StringBuilder SB2 = new StringBuilder(HEXRESULT);
                        SB2[(HEXRESULT.Length - 1)] = lastchar[0];
                        HEXRESULT = SB2.ToString();
                    }
                    else
                    {
                        int tempnumber = (int)(difference);
                        StringBuilder SB2 = new StringBuilder(HEXRESULT);
                        SB2[(HEXRESULT.Length - 1)] = mask[tempnumber - 10];
                        HEXRESULT = SB2.ToString();
                    }
                }
                return HEXRESULT;
        }
    }
}
