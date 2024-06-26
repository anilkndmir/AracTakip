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
    public partial class MyCarForm : Form
    {
        public MyCarForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string model = txtModel.Text;
            string year = txtYear.Text;
            string plate = txtPlate.Text;
            string name = txtName.Text;
            int km;

            // Km bilgisi geçerli bir sayı mı kontrol edin
            if (!int.TryParse(txtKm.Text, out km))
            {
                MessageBox.Show("Geçerli bir km değeri girin.");
                return;
            }
            string connectionString = "Server=.;Database=CarCareProDb;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Araclar (AracIsmi, Marka, Model, Yil, Plaka, Km, UserId) VALUES (@Name, @Brand, @Model, @Year, @Plate, @Km, @UserId)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Brand", brand);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Plate", plate);
                        command.Parameters.AddWithValue("@Km", km);
                        command.Parameters.AddWithValue("@UserId", LoginForm.LoggedInUserId); // Kullanıcının ID'si
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Araç bilgileri başarıyla kaydedildi.");
                    this.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }

        }
    }
}
