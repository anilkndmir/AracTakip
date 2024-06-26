using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCareProApp
{
    public partial class LoginForm : Form
    {
        public static int LoggedInUserId; // Kullanıcı ID'sini saklamak için
        private DatabaseHelper dbHelper;

        public LoginForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string password = txtParola.Text;

            string connectionString = "Server=.;Database=CarCareProDb;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Id FROM Users WHERE Mail = @Mail AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Mail", mail);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            LoggedInUserId = Convert.ToInt32(result);
                            MainForm mainForm = new MainForm();
                            this.Hide();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz e-posta veya şifre.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
