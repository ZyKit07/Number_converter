namespace Number_converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            autocountspeedminus = new System.Windows.Forms.Button();
            autocountspeedplus = new System.Windows.Forms.Button();
            nullbutton = new System.Windows.Forms.Button();
            autocountminusstart = new System.Windows.Forms.Button();
            maxbutton = new System.Windows.Forms.Button();
            autocountplusstart = new System.Windows.Forms.Button();
            numberplus = new System.Windows.Forms.Button();
            numberminus = new System.Windows.Forms.Button();
            speedshowlabel = new System.Windows.Forms.Label();
            RMbutton = new System.Windows.Forms.Button();
            rndbutton = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 17);
            label1.TabIndex = 6;
            label1.Text = "DEC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 17);
            label2.TabIndex = 7;
            label2.Text = "BIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 17);
            label3.TabIndex = 8;
            label3.Text = "HEX";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(52, 11);
            textBox1.MaxLength = 26;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(456, 21);
            textBox1.TabIndex = 9;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(52, 37);
            textBox2.MaxLength = 64;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(456, 21);
            textBox2.TabIndex = 10;
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // textBox3
            // 
            textBox3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox3.Location = new System.Drawing.Point(52, 63);
            textBox3.MaxLength = 16;
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(456, 21);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(496, 613);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // autocountspeedminus
            // 
            autocountspeedminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            autocountspeedminus.Location = new System.Drawing.Point(190, 647);
            autocountspeedminus.Name = "autocountspeedminus";
            autocountspeedminus.Size = new System.Drawing.Size(40, 25);
            autocountspeedminus.TabIndex = 17;
            autocountspeedminus.Text = "-";
            autocountspeedminus.UseVisualStyleBackColor = true;
            autocountspeedminus.Click += autocountspeedminus_Click;
            // 
            // autocountspeedplus
            // 
            autocountspeedplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            autocountspeedplus.Location = new System.Drawing.Point(291, 647);
            autocountspeedplus.Name = "autocountspeedplus";
            autocountspeedplus.Size = new System.Drawing.Size(40, 25);
            autocountspeedplus.TabIndex = 18;
            autocountspeedplus.Text = "+";
            autocountspeedplus.UseVisualStyleBackColor = true;
            autocountspeedplus.Click += autocountspeedplus_Click;
            // 
            // nullbutton
            // 
            nullbutton.Location = new System.Drawing.Point(15, 647);
            nullbutton.Name = "nullbutton";
            nullbutton.Size = new System.Drawing.Size(78, 52);
            nullbutton.TabIndex = 19;
            nullbutton.Text = "null";
            nullbutton.UseVisualStyleBackColor = true;
            nullbutton.Click += nullbutton_Click;
            // 
            // autocountminusstart
            // 
            autocountminusstart.Location = new System.Drawing.Point(96, 674);
            autocountminusstart.Name = "autocountminusstart";
            autocountminusstart.Size = new System.Drawing.Size(92, 25);
            autocountminusstart.TabIndex = 20;
            autocountminusstart.Text = "autocount--";
            autocountminusstart.UseVisualStyleBackColor = true;
            autocountminusstart.Click += autocountminusstart_Click;
            // 
            // maxbutton
            // 
            maxbutton.Location = new System.Drawing.Point(428, 647);
            maxbutton.Name = "maxbutton";
            maxbutton.Size = new System.Drawing.Size(77, 52);
            maxbutton.TabIndex = 21;
            maxbutton.Text = "max";
            maxbutton.UseVisualStyleBackColor = true;
            maxbutton.Click += maxbutton_Click;
            // 
            // autocountplusstart
            // 
            autocountplusstart.Location = new System.Drawing.Point(333, 674);
            autocountplusstart.Name = "autocountplusstart";
            autocountplusstart.Size = new System.Drawing.Size(92, 25);
            autocountplusstart.TabIndex = 22;
            autocountplusstart.Text = "autocount++";
            autocountplusstart.UseVisualStyleBackColor = true;
            autocountplusstart.Click += autocountplusstart_Click;
            // 
            // numberplus
            // 
            numberplus.Location = new System.Drawing.Point(333, 647);
            numberplus.Name = "numberplus";
            numberplus.Size = new System.Drawing.Size(92, 25);
            numberplus.TabIndex = 23;
            numberplus.Text = "number++";
            numberplus.UseVisualStyleBackColor = true;
            numberplus.Click += numberplus_Click;
            // 
            // numberminus
            // 
            numberminus.Location = new System.Drawing.Point(96, 647);
            numberminus.Name = "numberminus";
            numberminus.Size = new System.Drawing.Size(92, 25);
            numberminus.TabIndex = 24;
            numberminus.Text = "number--";
            numberminus.UseVisualStyleBackColor = true;
            numberminus.Click += numberminus_Click;
            // 
            // mylabel
            // 
            speedshowlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            speedshowlabel.Location = new System.Drawing.Point(233, 647);
            speedshowlabel.MaximumSize = new System.Drawing.Size(150, 150);
            speedshowlabel.Name = "mylabel";
            speedshowlabel.Size = new System.Drawing.Size(55, 52);
            speedshowlabel.TabIndex = 25;
            speedshowlabel.Text = "speed";
            speedshowlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RMbutton
            // 
            RMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RMbutton.Location = new System.Drawing.Point(291, 674);
            RMbutton.Name = "RMbutton";
            RMbutton.Size = new System.Drawing.Size(40, 25);
            RMbutton.TabIndex = 26;
            RMbutton.Text = "RM";
            toolTip1.SetToolTip(RMbutton, "enable/disable random mode");
            RMbutton.UseVisualStyleBackColor = true;
            RMbutton.Click += RMbutton_Click;
            // 
            // rndbutton
            // 
            rndbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rndbutton.Location = new System.Drawing.Point(190, 674);
            rndbutton.Name = "rndbutton";
            rndbutton.Size = new System.Drawing.Size(40, 25);
            rndbutton.TabIndex = 27;
            rndbutton.Text = "random";
            toolTip1.SetToolTip(rndbutton, "set random number from 0 to 2^64");
            rndbutton.UseVisualStyleBackColor = true;
            rndbutton.Click += rndbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(517, 721);
            Controls.Add(rndbutton);
            Controls.Add(RMbutton);
            Controls.Add(speedshowlabel);
            Controls.Add(numberminus);
            Controls.Add(numberplus);
            Controls.Add(autocountplusstart);
            Controls.Add(maxbutton);
            Controls.Add(autocountminusstart);
            Controls.Add(nullbutton);
            Controls.Add(autocountspeedplus);
            Controls.Add(autocountspeedminus);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Number converter";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button autocountspeedminus;
        private System.Windows.Forms.Button autocountspeedplus;
        private System.Windows.Forms.Button nullbutton;
        private System.Windows.Forms.Button autocountminusstart;
        private System.Windows.Forms.Button maxbutton;
        private System.Windows.Forms.Button autocountplusstart;
        private System.Windows.Forms.Button numberplus;
        private System.Windows.Forms.Button numberminus;
        private System.Windows.Forms.Label speedshowlabel;
        private System.Windows.Forms.Button RMbutton;
        private System.Windows.Forms.Button rndbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
