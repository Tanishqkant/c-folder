using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        // Controls
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblResult;
        private CheckBox chkTerms;
        private Label lblTermsMsg;

        public Form1()
        {
            InitializeComponent();

            // Username TextBox
            txtUsername = new TextBox { Location = new System.Drawing.Point(30, 30), Width = 200 };
            txtUsername.PlaceholderText = "Username";
            Controls.Add(txtUsername);

            // Password TextBox
            txtPassword = new TextBox { Location = new System.Drawing.Point(30, 70), Width = 200, UseSystemPasswordChar = true };
            txtPassword.PlaceholderText = "Password";
            Controls.Add(txtPassword);

            // Login Button
            btnLogin = new Button { Text = "Login", Location = new System.Drawing.Point(30, 110), Width = 200 };
            btnLogin.Click += BtnLogin_Click;
            Controls.Add(btnLogin);

            // Result Label
            lblResult = new Label { Location = new System.Drawing.Point(30, 150), Width = 200 };
            Controls.Add(lblResult);

            // Accept Terms CheckBox
            chkTerms = new CheckBox { Text = "Accept Terms", Location = new System.Drawing.Point(30, 180) };
            chkTerms.CheckedChanged += ChkTerms_CheckedChanged;
            Controls.Add(chkTerms);

            // Terms Message Label
            lblTermsMsg = new Label { Location = new System.Drawing.Point(30, 210), Width = 250 };
            Controls.Add(lblTermsMsg);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                lblResult.Text = "Login Successful";
            }
            else
            {
                lblResult.Text = "Invalid Credentials";
            }
        }

        private void ChkTerms_CheckedChanged(object sender, EventArgs e)
        {
            lblTermsMsg.Text = chkTerms.Checked ? "You have accepted the terms." : "";
        }
    }
}
