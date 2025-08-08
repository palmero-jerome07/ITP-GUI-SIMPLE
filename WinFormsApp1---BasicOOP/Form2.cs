using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1___BasicOOP
{
    public partial class Calculator : Form
    {
        private string result;
        private float num1;
        private float num2;
        private char operation;

        public Calculator()
        {
            InitializeComponent();
            this.MaximizeBox = false; // Disable maximize button
            this.BackColor = Color.WhiteSmoke;
            this.radioButton2.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Calculator_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ModernButton btn)
                {
                    btn.BorderRadius = 20;
                    btn.BackgroundColor = Color.FromArgb(46, 204, 113);
                    btn.TextColor = Color.White;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btn0.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                // Disable the textbox
                this.textBox1.Enabled = false;
                // Clear the textbox
                clearText();
                // Disable all calculator buttons
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        ctrl.Enabled = false;
                    }
                }
            }
            else
            {
                // Enable the textbox and buttons when "Off" is not checked
                this.textBox1.Enabled = true;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        ctrl.Enabled = true;
                    }
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // Clear the textbox
            clearText();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += this.btnDot.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Block character
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (textBox1.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
        private void clearText()
        {
            // Clear the textbox
            this.textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            operation = '+';
            clearText();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            operation = '-';
            clearText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            operation = '/';
            clearText();
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            operation = '*';
            clearText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(textBox1.Text);

            switch (operation)
            {
                case '+':
                    Addition addition = new Addition();
                    addition.num1 = num1;
                    addition.num2 = num2;
                    result = addition.add();
                    break;
                case '-':
                    Subtraction subtraction = new Subtraction();
                    subtraction.num1 = num1;
                    subtraction.num2 = num2;
                    result = subtraction.subtract();
                    break;
                case '/':
                    Divide divide = new Divide();
                    divide.num1 = num1;
                    divide.num2 = num2;
                    result = divide.divide();
                    break;
                case '*':
                    Multiply multiplication = new Multiply();
                    multiplication.num1 = num1;
                    multiplication.num2 = num2;
                    result = multiplication.multiply();
                    break;
                default:
                    result = "Error: Invalid operation.";
                    break;
            }

            textBox1.Text = result.ToString();
        }

        
    }
}
