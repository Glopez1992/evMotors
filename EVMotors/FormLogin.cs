using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string user = txtLogin.Text.Trim(); // Trim whitespace for better accuracy
            string password = txtPassword.Text;

            string connectionString = "Server=KYLEPC\\SQLEXPRESS;Database=EvMotorsDB;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT * FROM users WHERE [user] = @user AND [password] = @password";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {


                        checkCmd.Parameters.AddWithValue("@user", user);
                        checkCmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                this.Hide();
                                FormMain mainForm = new FormMain();
                                mainForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {

                                MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Consider logging the exception for debugging purposes
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = true;

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
