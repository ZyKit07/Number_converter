using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Number_converter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            speedshowlabel.Text = "speed " + autocountspeed.ToString() + "%";

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

            if (autocountplusstartcheck == false && autocountminusstartcheck == false)
                speedshowlabel.ForeColor = System.Drawing.Color.Gray;
            else
                speedshowlabel.ForeColor = System.Drawing.Color.Green;
        }

        /* 
           0000 -- 0  -- 00
           0001 -- 1  -- 01
           0010 -- 2  -- 02
           0011 -- 3  -- 03
           0100 -- 4  -- 04
           0101 -- 5  -- 05
           0110 -- 6  -- 06
           0111 -- 7  -- 07
           1000 -- 8  -- 08
           1001 -- 9  -- 09
           1010 -- 10 -- 0A
           1011 -- 11 -- 0B
           1100 -- 12 -- 0C
           1101 -- 13 -- 0D
           1110 -- 14 -- 0E
           1111 -- 15 -- 0F
        */

        int autocountspeed = 10;
        // 10% is my default speed.

        ulong decnumber = 0;
        ulong DECRESULT = 0;
        string BINRESULT = "0";
        string HEXRESULT = "0";

        bool deccheckok = false;
        bool bincheckok = false;
        bool hexcheckok = false;

        bool autocountplusstartcheck = false;
        bool autocountminusstartcheck = false;
        bool randommode = false;

        // Class instances create.
        DecToBinAlgorithm dectobin = new DecToBinAlgorithm();
        BinToDecAlgorithm bintodec = new BinToDecAlgorithm();
        HexToDecAlgorithm hextodec = new HexToDecAlgorithm();
        DecToHexAlgorithm dectohex = new DecToHexAlgorithm();
        DecimalInputCheck decimalinputcheck = new DecimalInputCheck();
        BinaryInputCheck binaryinputcheck = new BinaryInputCheck();
        HexadecimalInputCheck hexinputcheck = new HexadecimalInputCheck();
        Myulongrandomnumber mylongrnd = new Myulongrandomnumber();


        // Decimal input.
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string dectext = textBox1.Text;
                deccheckok = decimalinputcheck.Decinputcheckmethod(dectext); // input check ****

                if (deccheckok && textBox1.Text != "")
                {
                    dectext = dectext.Replace(" ", string.Empty);

                    try
                    {
                        decnumber = Convert.ToUInt64(dectext);
                    }
                    catch
                    {
                        decnumber = ulong.MaxValue;
                    }

                    // Decimal to binary call.
                    BINRESULT = dectobin.Dectobinmethod(decnumber);
                    // Decimal to hexadecimal call.
                    HEXRESULT = dectohex.Dectohexmethod(decnumber);                    

                    string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
                    {
                        NumberGroupSizes = new[] { 3 },
                        NumberGroupSeparator = " "
                    });
                    textBox1.Text = DECOUTPUT;
                    textBox2.Text = BINRESULT;
                    textBox3.Text = HEXRESULT;
                }
            }
        }

        // Binary input.
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string bintext = textBox2.Text;

                // Binary input check.
                bincheckok = binaryinputcheck.Bininputcheckmethod(bintext);                

                if (bincheckok && textBox2.Text != "")
                {
                    // Binary to decimal call.
                    DECRESULT = bintodec.Bintodecmethod(bintext);

                    decnumber = DECRESULT;

                    // Decimal to hexadecimal call.
                    HEXRESULT = dectohex.Dectohexmethod(decnumber);

                    string DECOUTPUT = DECRESULT.ToString("N0", new NumberFormatInfo()
                    {
                        NumberGroupSizes = new[] { 3 },
                        NumberGroupSeparator = " "
                    });
                    textBox1.Text = DECOUTPUT;
                    textBox3.Text = HEXRESULT;
                }
            }
        }

        // Hexadecimal input.
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string hextext = textBox3.Text;
                hextext = hextext.ToUpper();

                // Hexadecimal input check.
                hexcheckok = hexinputcheck.Hexinputcheckmethod(hextext);                

                if (hexcheckok && textBox3.Text != "")
                {
                    // Hexadecimal to decimal call.
                    DECRESULT = hextodec.Hextodecmethod(hextext);                    

                    decnumber = DECRESULT;

                    // Decimal to binary call.
                    BINRESULT = dectobin.Dectobinmethod(decnumber);                    

                    string DECOUTPUT = DECRESULT.ToString("N0", new NumberFormatInfo()
                    {
                        NumberGroupSizes = new[] { 3 },
                        NumberGroupSeparator = " "
                    });
                    textBox1.Text = DECOUTPUT;
                    textBox2.Text = BINRESULT;
                    textBox3.Text = hextext;
                }
            }
        }

        // Null button click.
        private void nullbutton_Click(object sender, EventArgs e)
        {
            decnumber = 0;
            autocountminusstartcheck = false;

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

            if (!autocountplusstartcheck && !autocountminusstartcheck)
                speedshowlabel.ForeColor = System.Drawing.Color.Gray;
            else
                speedshowlabel.ForeColor = System.Drawing.Color.Green;
        }

        // MAX button click.
        private void maxbutton_Click(object sender, EventArgs e)
        {
            decnumber = ulong.MaxValue;

            string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = " "
            });
            textBox1.Text = DECOUTPUT;
            textBox2.Text = Convert.ToString((long)decnumber, 2);
            textBox3.Text = Convert.ToString((long)decnumber, 16).ToUpper();
        }

        // Speed increase button click.
        private void autocountspeedplus_Click(object sender, EventArgs e)
        {
            if (autocountspeed < 90)
            {
                autocountspeed += 10;
                speedshowlabel.Text = "speed " + autocountspeed.ToString() + "%";
            }

            if (!autocountplusstartcheck && !autocountminusstartcheck && !randommode)
                speedshowlabel.ForeColor = System.Drawing.Color.Gray;
            else
                speedshowlabel.ForeColor = System.Drawing.Color.Green;
        }

        // Speed reduce button click.
        private void autocountspeedminus_Click(object sender, EventArgs e)
        {
            if (autocountspeed > 10)
            {
                autocountspeed -= 10;
                speedshowlabel.Text = "speed " + autocountspeed.ToString() + "%";
            }

            if (!autocountplusstartcheck && !autocountminusstartcheck && !randommode)
                speedshowlabel.ForeColor = System.Drawing.Color.Gray;
            else
                speedshowlabel.ForeColor = System.Drawing.Color.Green;
        }

        // Number++ button click.
        private void numberplus_Click(object sender, EventArgs e)
        {
            decnumber++;

            // Decimal to binary call.
            BINRESULT = dectobin.Dectobinmethod(decnumber);
            // Decimal to hexadecimal call.
            HEXRESULT = dectohex.Dectohexmethod(decnumber);

            string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = " "
            });
            textBox1.Text = DECOUTPUT;
            textBox2.Text = BINRESULT;
            textBox3.Text = HEXRESULT;
        }

        // Number-- button click.
        private void numberminus_Click(object sender, EventArgs e)
        {
            if (decnumber > 0)
            {
                decnumber--;

                // Decimal to binary call.
                BINRESULT = dectobin.Dectobinmethod(decnumber);
                // Decimal to hexadecimal call.
                HEXRESULT = dectohex.Dectohexmethod(decnumber);                

                string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
                {
                    NumberGroupSizes = new[] { 3 },
                    NumberGroupSeparator = " "
                });
                textBox1.Text = DECOUTPUT;
                textBox2.Text = BINRESULT;
                textBox3.Text = HEXRESULT;
            }
        }

        // Autocount++ button click.
        private void autocountplusstart_Click(object sender, EventArgs e)
        {
            if (!autocountplusstartcheck)
            {
                autocountplusstartcheck = true;
                autocountminusstartcheck = false;
            }
            else
                autocountplusstartcheck = false;

            System.Threading.Thread thread1 = new System.Threading.Thread(() => DoTheLoopPlus());
            thread1.Start();

            if (!autocountplusstartcheck && !autocountminusstartcheck)
                speedshowlabel.ForeColor = System.Drawing.Color.Gray;
            else
                speedshowlabel.ForeColor = System.Drawing.Color.Green;
        }

        // Autocount-- button click.
        private void autocountminusstart_Click(object sender, EventArgs e)
        {
            if (decnumber > 0)
            {
                if (!autocountminusstartcheck)
                {
                    autocountminusstartcheck = true;
                    autocountplusstartcheck = false;
                }
                else
                    autocountminusstartcheck = false;

                System.Threading.Thread thread1 = new System.Threading.Thread(() => DoTheLoopMinus());
                thread1.Start();
            }
            else
            {
                autocountminusstartcheck = false;
                autocountplusstartcheck = false;
            }

            if (!autocountplusstartcheck && !autocountminusstartcheck)
                speedshowlabel.ForeColor = System.Drawing.Color.Gray;
            else
                speedshowlabel.ForeColor = System.Drawing.Color.Green;
        }

        // Decnumber increase loop.
        private void DoTheLoopPlus()
        {
            do
            {
                decnumber++;

                // Decimal to binary call.
                BINRESULT = dectobin.Dectobinmethod(decnumber);
                // Decimal to hexadecimal call.
                HEXRESULT = dectohex.Dectohexmethod(decnumber);                

                string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
                {
                    NumberGroupSizes = new[] { 3 },
                    NumberGroupSeparator = " "
                });

                textBox1.BeginInvoke(new Action(() => { textBox1.Text = DECOUTPUT; }));
                textBox2.BeginInvoke(new Action(() => { textBox2.Text = BINRESULT; }));
                textBox2.BeginInvoke(new Action(() => { textBox3.Text = HEXRESULT; }));

                if (autocountspeed < 70)
                    System.Threading.Thread.Sleep((650 - ((autocountspeed * 5) * 2)));

                for (int i = 0; i < (105000 - ((Math.Pow(autocountspeed, 2) * 10))); i++)
                {
                    //empty cycle for sleep
                }
            }
            while (autocountplusstartcheck && !autocountminusstartcheck);
        }

        // Decnumber reduce loop.
        private void DoTheLoopMinus()
        {
            if (decnumber == 0)
            {
                autocountplusstartcheck = false;
                autocountminusstartcheck = false;
            }

            do
            {
                decnumber--;

                if (decnumber == 0)
                    autocountminusstartcheck = false;

                if (!autocountplusstartcheck && !autocountminusstartcheck)
                    speedshowlabel.ForeColor = System.Drawing.Color.Gray;
                else
                    speedshowlabel.ForeColor = System.Drawing.Color.Green;

                // Decimal to binary call.
                BINRESULT = dectobin.Dectobinmethod(decnumber);
                // Decimal to hexadecimal call.
                HEXRESULT = dectohex.Dectohexmethod(decnumber);                

                string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
                {
                    NumberGroupSizes = new[] { 3 },
                    NumberGroupSeparator = " "
                });

                textBox1.BeginInvoke(new Action(() => { textBox1.Text = DECOUTPUT; }));
                textBox2.BeginInvoke(new Action(() => { textBox2.Text = BINRESULT; }));
                textBox2.BeginInvoke(new Action(() => { textBox3.Text = HEXRESULT; }));

                if (autocountspeed < 70)
                    System.Threading.Thread.Sleep((650 - ((autocountspeed * 5) * 2)));

                for (int i = 0; i < (105000 - ((Math.Pow(autocountspeed, 2) * 10))); i++)
                {
                    //empty cycle for sleep
                }
            }
            while (autocountminusstartcheck && !autocountplusstartcheck && decnumber > 0);
        }

        // Random loop.
        private void DoTheRandomLoop()
        {
            do
            {
                decnumber = mylongrnd.Setrandomnumbermethod(randommode);

                // Decimal to binary call.
                BINRESULT = dectobin.Dectobinmethod(decnumber);
                // Decimal to hexadecimal call.
                HEXRESULT = dectohex.Dectohexmethod(decnumber);

                string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
                {
                    NumberGroupSizes = new[] { 3 },
                    NumberGroupSeparator = " "
                });

                textBox1.BeginInvoke(new Action(() => { textBox1.Text = DECOUTPUT; }));
                textBox2.BeginInvoke(new Action(() => { textBox2.Text = BINRESULT; }));
                textBox2.BeginInvoke(new Action(() => { textBox3.Text = HEXRESULT; }));

                if (autocountspeed < 70)
                    System.Threading.Thread.Sleep((650 - ((autocountspeed * 5) * 2)));

                for (int i = 0; i < (105000 - ((Math.Pow(autocountspeed, 2) * 10))); i++)
                {
                    //empty cycle for sleep
                }
            }
            while (randommode);
        }

        // Rand button click.
        private void rndbutton_Click(object sender, EventArgs e)
        {
            decnumber = mylongrnd.Setrandomnumbermethod(randommode);

            // Decimal to binary call.
            BINRESULT = dectobin.Dectobinmethod(decnumber);
            // Decimal to hexadecimal call.
            HEXRESULT = dectohex.Dectohexmethod(decnumber);

            string DECOUTPUT = decnumber.ToString("N0", new NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = " "
            });
            textBox1.Text = DECOUTPUT;
            textBox2.Text = BINRESULT;
            textBox3.Text = HEXRESULT;
        }

        // RMbutton click & buttons unavailable code
        private void RMbutton_Click(object sender, EventArgs e)
        {
            if (!randommode)
            {
                randommode = true;
                autocountplusstartcheck = false;
                autocountminusstartcheck = false;
                speedshowlabel.ForeColor = System.Drawing.Color.Green;

                System.Threading.Thread thread1 = new System.Threading.Thread(() => DoTheRandomLoop());
                thread1.Start();
            }
            else
            {
                randommode = false;
                speedshowlabel.ForeColor = System.Drawing.Color.Gray;
            }                

            if (randommode)
            {
                rndbutton.Enabled = false;

                nullbutton.Enabled = false;
                maxbutton.Enabled = false;

                numberminus.Enabled = false;
                numberplus.Enabled = false;

                autocountminusstart.Enabled = false;
                autocountplusstart.Enabled = false;
            }

            if (!randommode)
            {
                rndbutton.Enabled = true;

                nullbutton.Enabled = true;
                maxbutton.Enabled = true;

                numberminus.Enabled = true;
                numberplus.Enabled = true;

                autocountminusstart.Enabled = true;
                autocountplusstart.Enabled = true;
            }

            
        }

        // Exit program.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
