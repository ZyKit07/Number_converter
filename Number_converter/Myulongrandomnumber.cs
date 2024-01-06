using System;

namespace Number_converter
{
    internal class Myulongrandomnumber
    {
        public ulong Setrandomnumbermethod(bool randommode)
        {
            ulong decresult = 0;
            Random rrr = new Random();

            int fiveways = rrr.Next(0, 100);
            ulong mymultiplier = (ulong.MaxValue / int.MaxValue);

            if (fiveways < 20)
                decresult = Convert.ToUInt32(rrr.Next(0, 1000));

            else if (fiveways > 20 && fiveways < 40)
                decresult = Convert.ToUInt32(rrr.Next(1000, 1000000));

            else if (fiveways > 40 && fiveways < 60)
                decresult = Convert.ToUInt32(rrr.Next(1000000, int.MaxValue));

            else if (fiveways > 60 && fiveways < 80)
                decresult = (ulong)(rrr.Next(0, int.MaxValue)) * (mymultiplier / 100);

            else
                decresult = (ulong)(rrr.Next(0, int.MaxValue)) * mymultiplier;

            return decresult;
        }
    }
}
