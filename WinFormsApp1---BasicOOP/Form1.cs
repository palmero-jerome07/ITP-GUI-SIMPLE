namespace WinFormsApp1___BasicOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\USER-PC\Downloads\pngwing.com.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: fit image to box
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
                if (this.txtEmail.Text != "jerome@example.com" && this.txtPassword.Text != "admin123")
                {
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sign-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

