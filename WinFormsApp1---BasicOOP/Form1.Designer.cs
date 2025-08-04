
namespace WinFormsApp1___BasicOOP
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
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            toolTip5 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            toolTip6 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Roboto", 12F);
            lblEmail.ForeColor = SystemColors.ButtonFace;
            lblEmail.Location = new Point(75, 42);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "EMAIL :";
            lblEmail.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Roboto", 12F);
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(35, 91);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(102, 19);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "PASSWORD :";
            lblPassword.Click += label2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(143, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 22);
            txtEmail.TabIndex = 2;
            toolTip1.SetToolTip(txtEmail, "Enter an email");
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ActiveCaptionText;
            txtPassword.Location = new Point(143, 91);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(237, 22);
            txtPassword.TabIndex = 3;
            toolTip2.SetToolTip(txtPassword, "Enter a password");
            // 
            // btnSignIn
            // 
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.InfoText;
            btnSignIn.Location = new Point(305, 140);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Sign In";
            toolTip3.SetToolTip(btnSignIn, "Sign In");
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Roboto Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(277, 169);
            label1.Name = "label1";
            label1.Size = new Size(103, 14);
            label1.TabIndex = 5;
            label1.Text = "Create an account";
            toolTip4.SetToolTip(label1, "Create an account");
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(143, 140);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 32);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Agree to Terms\r\nand Conditions";
            toolTip5.SetToolTip(checkBox1, "Agree to terms and conditions");
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSignIn);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(44, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 214);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "SIGN UP or SIGN IN!";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(225, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 72);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            toolTip6.SetToolTip(pictureBox1, "DOTA LOGO");
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(537, 420);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Label label1;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private ToolTip toolTip5;
        private PictureBox pictureBox1;
        private ToolTip toolTip6;
    }
}
