using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCareProApp
{
    public partial class MainForm : Form
    {
        private BluetoothConnection _bluetoothConnection;
        private OBD2Communication _obd2Communication;
        private SerialPort serialPort;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnConnect.Click += BtnConnect_Click;
            BtnGetFaultCodes.Click += BtnGetFaultCodes_Click;
            btnClearFaultCodes.Click += BtnClearFaultCodes_Click;
            btnGetFuelLevel.Click += btnGetFuelLevel_Click;
            btnGetCoolantTemp.Click += btnGetCoolantTemp_Click;
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Seri port ayarları (OBD2 cihazına göre)
                serialPort = new SerialPort();
                serialPort.PortName = "COM3"; // Bluetooth cihazının bağlandığı COM portu
                serialPort.BaudRate = 9600; // OBD2 cihazının baud rate ayarına göre
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Handshake = Handshake.None;
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                MessageBox.Show("Bluetooth bağlantısı başarılı!");
                serialPort.Write("01 0C\r"); // Motor devrini sorgulama 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantı hatası: {ex.Message}");
            }
        }
        private void BtnGetFaultCodes_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("03\r"); // Motor hata kodlarını sorgulama komutu
                System.Threading.Thread.Sleep(500);
                string data = serialPort.ReadExisting();

                if (!string.IsNullOrEmpty(data))
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        txtFaultOutput.AppendText("Motor Hata Kodları:\n");
                        txtFaultOutput.AppendText(data + "\n");
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        txtFaultOutput.AppendText("Motor Hata Kodları bulunamadı.\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata kodları sorgulama hatası: {ex.Message}");
            }
        }
        private void BtnClearFaultCodes_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("04\r"); // Motor hata kodlarını silme komutu
                System.Threading.Thread.Sleep(500);
                string data = serialPort.ReadExisting();
                this.Invoke(new MethodInvoker(delegate
                {
                    txtFaultOutput.AppendText("Motor Hata Kodları temizlendi.\n");
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata kodları temizleme hatası: {ex.Message}");
            }
        }
        private void btnGetFuelLevel_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("01 2F\r"); // Yakıt seviyesi sorgulama komutu
                System.Threading.Thread.Sleep(500);
                string data = serialPort.ReadExisting();
                if (!string.IsNullOrEmpty(data))
                {
                    string[] dataArray = data.Split(' '); // Gelen veri boşluklarla ayrılmış olabilir
                    if (dataArray.Length >= 2 && dataArray[0] == "41" && dataArray[1] == "2F")
                    {
                        int fuelLevelHex = Convert.ToInt32(dataArray[2], 16);
                        double fuelLevel = (fuelLevelHex * 100.0) / 255.0;
                        this.Invoke(new MethodInvoker(delegate
                        {
                            txtFuelOutput.AppendText($"Yakıt Seviyesi: {fuelLevel}%\n");
                        }));
                    }
                    else
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            txtFuelOutput.AppendText("Yakıt seviyesi verisi alınamadı.\n");
                        }));
                    }
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        txtFuelOutput.AppendText("Yakıt seviyesi verisi alınamadı.\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yakıt seviyesi sorgulama hatası: {ex.Message}");
            }
        }
        private void btnGetCoolantTemp_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Write("01 05\r"); // Soğutma suyu sıcaklığı sorgulama komutu
                System.Threading.Thread.Sleep(500);
                string data = serialPort.ReadExisting();
                if (!string.IsNullOrEmpty(data))
                {
                    string[] dataArray = data.Split(' '); // Gelen veri boşluklarla ayrılmış olabilir
                    if (dataArray.Length >= 2 && dataArray[0] == "41" && dataArray[1] == "05")
                    {
                        int tempHex = Convert.ToInt32(dataArray[2], 16);
                        int coolantTemp = tempHex - 40; // OBD2 protokolüne göre sıcaklık hesaplama
                        this.Invoke(new MethodInvoker(delegate
                        {
                            txtTempOutput.AppendText($"Soğutma Suyu Sıcaklığı: {coolantTemp}°C\n");
                        }));
                    }
                    else
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            txtTempOutput.AppendText("Soğutma suyu sıcaklığı verisi alınamadı.\n");
                        }));
                    }
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        txtTempOutput.AppendText("Soğutma suyu sıcaklığı verisi alınamadı.\n");
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Soğutma suyu sıcaklığı sorgulama hatası: {ex.Message}");
            }
        }
        private void btnMyCar_Click(object sender, EventArgs e)
        {
            MyCarForm myCarForm = new MyCarForm();
            myCarForm.ShowDialog();
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadExisting();
                this.Invoke(new MethodInvoker(delegate
                {
                    txtRpmOutput.AppendText(data + "\n");
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri okuma hatası: {ex.Message}");
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        private void btnBakim_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=CarCareProDb;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Km FROM Araclar WHERE UserId = @UserId ORDER BY Id DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", LoginForm.LoggedInUserId);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int currentKm = Convert.ToInt32(result);

                            int maintenanceInterval = 10000;
                            int nextMaintenance = (currentKm / maintenanceInterval + 1) * maintenanceInterval;
                            int kmLeft = nextMaintenance - currentKm;

                            MessageBox.Show($"Bakımına {kmLeft} km kaldı.");
                        }
                        else
                        {
                            MessageBox.Show("Araç bilgileri bulunamadı.");
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
