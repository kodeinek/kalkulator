namespace kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 49);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Hex",
            "Dec",
            "Oct",
            "Bin"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 188);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(79, 88);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Location = new System.Drawing.Point(56, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(440, 56);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.UseWaitCursor = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Qword",
            "Dword",
            "Word",
            "Bajt"});
            this.checkedListBox2.Location = new System.Drawing.Point(12, 303);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(79, 88);
            this.checkedListBox2.TabIndex = 4;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "(";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOpenBracket_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "RoL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Or";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(111, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Lsh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Not";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(159, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "Mod";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(160, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = ")";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonCloseBracket_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(159, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 35);
            this.button8.TabIndex = 12;
            this.button8.Text = "RoR";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(159, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 35);
            this.button9.TabIndex = 13;
            this.button9.Text = "Xor";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(160, 314);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 35);
            this.button10.TabIndex = 14;
            this.button10.Text = "Rsh";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(159, 356);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 35);
            this.button11.TabIndex = 15;
            this.button11.Text = "And";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(208, 146);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 35);
            this.button12.TabIndex = 16;
            this.button12.Text = "A";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(208, 188);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 35);
            this.button13.TabIndex = 17;
            this.button13.Text = "B";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(208, 230);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(43, 35);
            this.button14.TabIndex = 18;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(208, 272);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(43, 35);
            this.button15.TabIndex = 19;
            this.button15.Text = "D";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(208, 314);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(43, 35);
            this.button16.TabIndex = 20;
            this.button16.Text = "E";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(208, 356);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(43, 35);
            this.button17.TabIndex = 21;
            this.button17.Text = "F";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(257, 146);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(43, 35);
            this.button18.TabIndex = 22;
            this.button18.Text = "MC";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(257, 188);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(43, 35);
            this.button19.TabIndex = 23;
            this.button19.Text = "<-";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(257, 230);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(43, 35);
            this.button20.TabIndex = 24;
            this.button20.Text = "7";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(257, 272);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(43, 35);
            this.button21.TabIndex = 25;
            this.button21.Text = "4";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(257, 314);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(43, 35);
            this.button22.TabIndex = 26;
            this.button22.Text = "1";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(257, 356);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(92, 35);
            this.button23.TabIndex = 27;
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(306, 146);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(43, 35);
            this.button24.TabIndex = 28;
            this.button24.Text = "MR";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(306, 188);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(43, 35);
            this.button25.TabIndex = 29;
            this.button25.Text = "CE";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(306, 230);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(43, 35);
            this.button26.TabIndex = 30;
            this.button26.Text = "8";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(306, 272);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(43, 35);
            this.button27.TabIndex = 31;
            this.button27.Text = "5";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(306, 314);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(43, 35);
            this.button28.TabIndex = 32;
            this.button28.Text = "2";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(355, 146);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(43, 35);
            this.button30.TabIndex = 34;
            this.button30.Text = "MS";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(355, 188);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(43, 35);
            this.button31.TabIndex = 35;
            this.button31.Text = "C";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(355, 230);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(43, 35);
            this.button32.TabIndex = 36;
            this.button32.Text = "9";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(355, 272);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(43, 35);
            this.button33.TabIndex = 37;
            this.button33.Text = "6";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(355, 314);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(43, 35);
            this.button34.TabIndex = 38;
            this.button34.Text = "3";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(355, 356);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(43, 35);
            this.button35.TabIndex = 39;
            this.button35.Text = ",";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(404, 146);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(43, 35);
            this.button36.TabIndex = 40;
            this.button36.Text = "M+";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(404, 188);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(43, 35);
            this.button37.TabIndex = 41;
            this.button37.Text = "+-";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(404, 230);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(43, 35);
            this.button38.TabIndex = 42;
            this.button38.Text = "/";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(404, 272);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(43, 35);
            this.button39.TabIndex = 43;
            this.button39.Text = "*";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(404, 314);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(43, 35);
            this.button40.TabIndex = 44;
            this.button40.Text = "-";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(404, 356);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(43, 35);
            this.button41.TabIndex = 45;
            this.button41.Text = "+";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(453, 314);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(43, 77);
            this.button42.TabIndex = 50;
            this.button42.Text = "=";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // button43
            // 
            this.button43.Location = new System.Drawing.Point(453, 272);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(43, 35);
            this.button43.TabIndex = 49;
            this.button43.Text = "1/x";
            this.button43.UseVisualStyleBackColor = true;
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(453, 230);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(43, 35);
            this.button44.TabIndex = 48;
            this.button44.Text = "%";
            this.button44.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(453, 188);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(43, 35);
            this.button45.TabIndex = 47;
            this.button45.Text = "√";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(453, 146);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(43, 35);
            this.button46.TabIndex = 46;
            this.button46.Text = "M-";
            this.button46.UseVisualStyleBackColor = true;
            this.button46.Click += new System.EventHandler(this.button46_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(526, 423);
            this.Controls.Add(this.button42);
            this.Controls.Add(this.button43);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.button46);
            this.Controls.Add(this.button41);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
    }
}

