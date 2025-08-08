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
        private float num1, num2, currentValue, lastValue;
        private string result, operation, lastOperator;
        bool isNewEntry = true;
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

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (isNewEntry)
            {
                textBox1.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                textBox1.Text += btn.Text;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
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
            Number_Click(sender, e);
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
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            float enteredValue = float.Parse(textBox1.Text);

            if (lastOperator != "")
            {
                // Perform the pending calculation
                switch (lastOperator)
                {
                    case "+": currentValue += enteredValue; break;
                    case "-": currentValue -= enteredValue; break;
                    case "*": currentValue *= enteredValue; break;
                    case "/": currentValue /= enteredValue; break;
                }
                textBox1.Text = currentValue.ToString();
            }
            else
            {
                currentValue = enteredValue;
            }

            lastOperator = btn.Text;
            isNewEntry = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                float enteredValue = float.Parse(textBox1.Text);

                switch (lastOperator)
                {
                    case "+": currentValue += enteredValue; break;
                    case "-": currentValue -= enteredValue; break;
                    case "*": currentValue *= enteredValue; break;
                    case "/": currentValue /= enteredValue; break;
                }

                textBox1.Text = currentValue.ToString();
                lastOperator = "";
                isNewEntry = true;
            }
        }

        
    }
}
