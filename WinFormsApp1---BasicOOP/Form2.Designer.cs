namespace WinFormsApp1___BasicOOP
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(18, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 43);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(222, 192, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button1.Location = new Point(251, 104);
            button1.Name = "button1";
            button1.Size = new Size(61, 46);
            button1.TabIndex = 1;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(186, 35, 35);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(175, 104);
            button2.Name = "button2";
            button2.Size = new Size(61, 46);
            button2.TabIndex = 2;
            button2.Text = "DEL";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(222, 192, 0);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button4.Location = new Point(251, 165);
            button4.Name = "button4";
            button4.Size = new Size(61, 46);
            button4.TabIndex = 4;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(222, 192, 0);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button5.Location = new Point(251, 226);
            button5.Name = "button5";
            button5.Size = new Size(61, 46);
            button5.TabIndex = 5;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(222, 192, 0);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button6.Location = new Point(251, 288);
            button6.Name = "button6";
            button6.Size = new Size(61, 46);
            button6.TabIndex = 6;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(222, 192, 0);
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button7.Location = new Point(251, 349);
            button7.Name = "button7";
            button7.Size = new Size(61, 46);
            button7.TabIndex = 7;
            button7.Text = "=";
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button9.Location = new Point(175, 165);
            button9.Name = "button9";
            button9.Size = new Size(61, 46);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLightLight;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button10.Location = new Point(175, 226);
            button10.Name = "button10";
            button10.Size = new Size(61, 46);
            button10.TabIndex = 10;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlLightLight;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button11.Location = new Point(175, 288);
            button11.Name = "button11";
            button11.Size = new Size(61, 46);
            button11.TabIndex = 11;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ControlLightLight;
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button12.Location = new Point(175, 349);
            button12.Name = "button12";
            button12.Size = new Size(61, 46);
            button12.TabIndex = 12;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ControlLightLight;
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button13.Location = new Point(23, 349);
            button13.Name = "button13";
            button13.Size = new Size(137, 46);
            button13.TabIndex = 17;
            button13.Text = "0";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ControlLightLight;
            button14.Cursor = Cursors.Hand;
            button14.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button14.Location = new Point(99, 288);
            button14.Name = "button14";
            button14.Size = new Size(61, 46);
            button14.TabIndex = 16;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ControlLightLight;
            button15.Cursor = Cursors.Hand;
            button15.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button15.Location = new Point(99, 226);
            button15.Name = "button15";
            button15.Size = new Size(61, 46);
            button15.TabIndex = 15;
            button15.Text = "5";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ControlLightLight;
            button16.Cursor = Cursors.Hand;
            button16.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button16.Location = new Point(99, 165);
            button16.Name = "button16";
            button16.Size = new Size(61, 46);
            button16.TabIndex = 14;
            button16.Text = "8";
            button16.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ControlLightLight;
            button19.Cursor = Cursors.Hand;
            button19.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button19.Location = new Point(23, 165);
            button19.Name = "button19";
            button19.Size = new Size(61, 46);
            button19.TabIndex = 19;
            button19.Text = "7";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.ControlLightLight;
            button20.Cursor = Cursors.Hand;
            button20.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button20.Location = new Point(23, 226);
            button20.Name = "button20";
            button20.Size = new Size(61, 46);
            button20.TabIndex = 20;
            button20.Text = "4";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = SystemColors.ControlLightLight;
            button21.Cursor = Cursors.Hand;
            button21.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            button21.Location = new Point(23, 288);
            button21.Name = "button21";
            button21.Size = new Size(61, 46);
            button21.TabIndex = 21;
            button21.Text = "1";
            button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(186, 35, 35);
            button22.Cursor = Cursors.Hand;
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button22.Location = new Point(99, 104);
            button22.Name = "button22";
            button22.Size = new Size(61, 46);
            button22.TabIndex = 22;
            button22.Text = "C";
            button22.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.WhiteSmoke;
            radioButton1.BackgroundImageLayout = ImageLayout.None;
            radioButton1.FlatAppearance.BorderSize = 0;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton1.Location = new Point(23, 104);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "ON";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.WhiteSmoke;
            radioButton2.BackgroundImageLayout = ImageLayout.None;
            radioButton2.FlatAppearance.BorderSize = 0;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radioButton2.Location = new Point(23, 130);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "OFF";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(332, 422);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}