using System;
using System.Windows.Forms;
using FormEVMotors;
using Microsoft.Data.SqlClient;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MainFormEVMotors
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
                      
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = $"EvMotors - {DateTime.Now:dd/MM/yyyy}";
            this.AcceptButton = btnLogin;
            this.ActiveControl = lblSubtitle1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Contains(" "))
            {
                MessageBox.Show("Password cannot contain spaces.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool isValid = DataAccess.ValidateLogin(user, password);

                if (isValid)
                {
                    this.Hide();
                    FormMain mainForm = new FormMain();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            txtPassword.UseSystemPasswordChar = true;

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
