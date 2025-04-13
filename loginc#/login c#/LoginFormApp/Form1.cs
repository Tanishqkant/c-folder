using System;
using System.Windows.Forms;

namespace LoginFormApp
{
   public class Form1 : Form
 // ✅ Removed 'partial'
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private RadioButton rdoAdmin;
        private RadioButton rdoUser;
        private CheckBox chkRememberMe;
        private Button btnLogin;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Login Form";
            this.Width = 300;
            this.Height = 300;

            // Username label and textbox
            Label lblUsername = new Label() { Text = "Username", Top = 20, Left = 20 };
            txtUsername = new TextBox() { Top = 40, Left = 20, Width = 200 };

            // Password label and textbox
            Label lblPassword = new Label() { Text = "Password", Top = 70, Left = 20 };
            txtPassword = new TextBox() { Top = 90, Left = 20, Width = 200, UseSystemPasswordChar = true };

            // Radio buttons
            rdoAdmin = new RadioButton() { Text = "Admin", Top = 130, Left = 20 };
            rdoUser = new RadioButton() { Text = "User", Top = 150, Left = 20 };
            rdoUser.Checked = true; // Default selection

            // Remember Me checkbox
            chkRememberMe = new CheckBox() { Text = "Remember Me", Top = 180, Left = 20 };

            // Login button
            btnLogin = new Button() { Text = "Login", Top = 210, Left = 20 };
            btnLogin.Click += BtnLogin_Click;

            // Add controls to form
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(rdoAdmin);
            this.Controls.Add(rdoUser);
            this.Controls.Add(chkRememberMe);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = rdoAdmin.Checked ? "Admin" : "User";
            bool rememberMe = chkRememberMe.Checked;

            if (username == "admin" && password == "123")
            {
                string message = $"Welcome {role} {username}!\n";
                if (rememberMe)
                    message += "You will be remembered next time.";
                MessageBox.Show(message, "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
