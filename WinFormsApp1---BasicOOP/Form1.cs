namespace WinFormsApp1___BasicOOP
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            Calculator form2 = new Calculator();
            form2.Show();
            this.Hide(); // Optional: hide the current form
            //InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calculator form2 = new Calculator();
            form2.Show();
            this.Hide(); // Optional: hide the current form
            pictureBox1.Image = Image.FromFile(@"C:\Users\USER-PC\Downloads\pngwing.com.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //This is picture box for the logo
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (this.txtEmail.Text == "")
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!this.checkBox1.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.txtEmail.Text != "jerome@example.com" || this.txtPassword.Text != "admin123")
                {
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sign-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the next form
                    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

