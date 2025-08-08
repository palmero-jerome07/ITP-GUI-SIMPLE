

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            textBox1 = new TextBox();
            btnDivide = new Button();
            button2 = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnClear = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            helpProvider1 = new HelpProvider();
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
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(222, 192, 0);
            btnDivide.Cursor = Cursors.Hand;
            btnDivide.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btnDivide.Location = new Point(251, 104);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(61, 46);
            btnDivide.TabIndex = 1;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += button1_Click;
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
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(222, 192, 0);
            btnSubtract.Cursor = Cursors.Hand;
            btnSubtract.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btnSubtract.FlatAppearance.BorderSize = 0;
            btnSubtract.FlatStyle = FlatStyle.Flat;
            btnSubtract.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btnSubtract.Location = new Point(251, 165);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(61, 46);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += button4_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(222, 192, 0);
            btnMultiply.Cursor = Cursors.Hand;
            btnMultiply.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btnMultiply.Location = new Point(251, 226);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(61, 46);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(222, 192, 0);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(251, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button6_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(222, 192, 0);
            btnEquals.Cursor = Cursors.Hand;
            btnEquals.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btnEquals.FlatAppearance.BorderSize = 0;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btnEquals.Location = new Point(251, 349);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(61, 46);
            btnEquals.TabIndex = 7;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += button7_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlLightLight;
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn9.Location = new Point(175, 165);
            btn9.Name = "btn9";
            btn9.Size = new Size(61, 46);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlLightLight;
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn6.Location = new Point(175, 226);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 46);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlLightLight;
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn3.Location = new Point(175, 288);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 46);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ControlLightLight;
            btnDot.Cursor = Cursors.Hand;
            btnDot.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btnDot.Location = new Point(175, 349);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(61, 46);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlLightLight;
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn0.Location = new Point(23, 349);
            btn0.Name = "btn0";
            btn0.Size = new Size(137, 46);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlLightLight;
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn2.Location = new Point(99, 288);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 46);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += button14_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlLightLight;
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn5.Location = new Point(99, 226);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 46);
            btn5.TabIndex = 15;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlLightLight;
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn8.Location = new Point(99, 165);
            btn8.Name = "btn8";
            btn8.Size = new Size(61, 46);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlLightLight;
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn7.Location = new Point(23, 165);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 46);
            btn7.TabIndex = 19;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlLightLight;
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn4.Location = new Point(23, 226);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 46);
            btn4.TabIndex = 20;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlLightLight;
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.BorderColor = Color.FromArgb(222, 192, 0);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Roboto", 20.25F, FontStyle.Bold);
            btn1.Location = new Point(23, 288);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 46);
            btn1.TabIndex = 21;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button21_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(186, 35, 35);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(99, 104);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 46);
            btnClear.TabIndex = 22;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button22_Click;
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
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(332, 422);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnClear);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btnEquals);
            Controls.Add(btnAdd);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(button2);
            Controls.Add(btnDivide);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        // Find and remove any duplicate btnDot_Click event handler definitions in this file.
        // Ensure only one definition exists for btnDot_Click in the Calculator class.



        #endregion

        private TextBox textBox1;
        private Button btnDivide;
        private Button button2;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnAdd;
        private Button btnEquals;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btnDot;
        private Button btn0;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btnClear;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private HelpProvider helpProvider1;
    }
}