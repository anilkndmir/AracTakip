using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCareProApp
{
    public partial class RegisterForm : Form
    {
        private DatabaseHelper dbHelper;
        public RegisterForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            string name = txtAd.Text;
            string surname = txtSoyad.Text;
            string number = txtTelNo.Text; 
            string mail = txtMail.Text;
            string password = txtParola.Text;

            if (dbHelper.RegisterUser(name, surname, number, mail, password))
            {
                MessageBox.Show("Kayıt başarılı!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Kayıt başarısız. Lütfen tekrar deneyin.");
            }
        }
    }
}
