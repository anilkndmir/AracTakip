namespace CarCareProApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtRpmOutput = new System.Windows.Forms.TextBox();
            this.lblRpm = new System.Windows.Forms.Label();
            this.BtnGetFaultCodes = new System.Windows.Forms.Button();
            this.txtFaultOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearFaultCodes = new System.Windows.Forms.Button();
            this.btnMyCar = new System.Windows.Forms.Button();
            this.btnGetFuelLevel = new System.Windows.Forms.Button();
            this.lblFuelLevel = new System.Windows.Forms.Label();
            this.txtFuelOutput = new System.Windows.Forms.TextBox();
            this.btnGetCoolantTemp = new System.Windows.Forms.Button();
            this.lblSuSicakligi = new System.Windows.Forms.Label();
            this.txtTempOutput = new System.Windows.Forms.TextBox();
            this.btnBakim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 15);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 42);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "OBD2\'ye Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // txtRpmOutput
            // 
            this.txtRpmOutput.Location = new System.Drawing.Point(111, 142);
            this.txtRpmOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtRpmOutput.Name = "txtRpmOutput";
            this.txtRpmOutput.Size = new System.Drawing.Size(99, 22);
            this.txtRpmOutput.TabIndex = 1;
            // 
            // lblRpm
            // 
            this.lblRpm.AutoSize = true;
            this.lblRpm.Location = new System.Drawing.Point(16, 145);
            this.lblRpm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRpm.Name = "lblRpm";
            this.lblRpm.Size = new System.Drawing.Size(79, 16);
            this.lblRpm.TabIndex = 2;
            this.lblRpm.Text = "Motor Devri:";
            // 
            // BtnGetFaultCodes
            // 
            this.BtnGetFaultCodes.Location = new System.Drawing.Point(136, 15);
            this.BtnGetFaultCodes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetFaultCodes.Name = "BtnGetFaultCodes";
            this.BtnGetFaultCodes.Size = new System.Drawing.Size(112, 42);
            this.BtnGetFaultCodes.TabIndex = 3;
            this.BtnGetFaultCodes.Text = "Hata Görüntüle";
            this.BtnGetFaultCodes.UseVisualStyleBackColor = true;
            this.BtnGetFaultCodes.Click += new System.EventHandler(this.BtnGetFaultCodes_Click);
            // 
            // txtFaultOutput
            // 
            this.txtFaultOutput.Location = new System.Drawing.Point(111, 174);
            this.txtFaultOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaultOutput.Multiline = true;
            this.txtFaultOutput.Name = "txtFaultOutput";
            this.txtFaultOutput.Size = new System.Drawing.Size(99, 24);
            this.txtFaultOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hata Kodları:";
            // 
            // btnClearFaultCodes
            // 
            this.btnClearFaultCodes.Location = new System.Drawing.Point(136, 64);
            this.btnClearFaultCodes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFaultCodes.Name = "btnClearFaultCodes";
            this.btnClearFaultCodes.Size = new System.Drawing.Size(112, 42);
            this.btnClearFaultCodes.TabIndex = 6;
            this.btnClearFaultCodes.Text = "Hata Temizle\r\n";
            this.btnClearFaultCodes.UseVisualStyleBackColor = true;
            this.btnClearFaultCodes.Click += new System.EventHandler(this.BtnClearFaultCodes_Click);
            // 
            // btnMyCar
            // 
            this.btnMyCar.Location = new System.Drawing.Point(256, 15);
            this.btnMyCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyCar.Name = "btnMyCar";
            this.btnMyCar.Size = new System.Drawing.Size(112, 42);
            this.btnMyCar.TabIndex = 7;
            this.btnMyCar.Text = "Aracım";
            this.btnMyCar.UseVisualStyleBackColor = true;
            this.btnMyCar.Click += new System.EventHandler(this.btnMyCar_Click);
            // 
            // btnGetFuelLevel
            // 
            this.btnGetFuelLevel.Location = new System.Drawing.Point(16, 64);
            this.btnGetFuelLevel.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetFuelLevel.Name = "btnGetFuelLevel";
            this.btnGetFuelLevel.Size = new System.Drawing.Size(115, 42);
            this.btnGetFuelLevel.TabIndex = 8;
            this.btnGetFuelLevel.Text = "Yakıt Görüntüle";
            this.btnGetFuelLevel.UseVisualStyleBackColor = true;
            this.btnGetFuelLevel.Click += new System.EventHandler(this.btnGetFuelLevel_Click);
            // 
            // lblFuelLevel
            // 
            this.lblFuelLevel.AutoSize = true;
            this.lblFuelLevel.Location = new System.Drawing.Point(232, 142);
            this.lblFuelLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuelLevel.Name = "lblFuelLevel";
            this.lblFuelLevel.Size = new System.Drawing.Size(95, 16);
            this.lblFuelLevel.TabIndex = 9;
            this.lblFuelLevel.Text = "Yakıt Seviyesi:";
            // 
            // txtFuelOutput
            // 
            this.txtFuelOutput.Location = new System.Drawing.Point(341, 138);
            this.txtFuelOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtFuelOutput.Name = "txtFuelOutput";
            this.txtFuelOutput.Size = new System.Drawing.Size(132, 22);
            this.txtFuelOutput.TabIndex = 10;
            // 
            // btnGetCoolantTemp
            // 
            this.btnGetCoolantTemp.Location = new System.Drawing.Point(256, 64);
            this.btnGetCoolantTemp.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetCoolantTemp.Name = "btnGetCoolantTemp";
            this.btnGetCoolantTemp.Size = new System.Drawing.Size(112, 42);
            this.btnGetCoolantTemp.TabIndex = 11;
            this.btnGetCoolantTemp.Text = "Soğutma Suyu Sıcaklığı";
            this.btnGetCoolantTemp.UseVisualStyleBackColor = true;
            this.btnGetCoolantTemp.Click += new System.EventHandler(this.btnGetCoolantTemp_Click);
            // 
            // lblSuSicakligi
            // 
            this.lblSuSicakligi.AutoSize = true;
            this.lblSuSicakligi.Location = new System.Drawing.Point(228, 170);
            this.lblSuSicakligi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuSicakligi.Name = "lblSuSicakligi";
            this.lblSuSicakligi.Size = new System.Drawing.Size(97, 32);
            this.lblSuSicakligi.TabIndex = 12;
            this.lblSuSicakligi.Text = "Soğutma Suyu \r\n     Sıcaklığı:";
            // 
            // txtTempOutput
            // 
            this.txtTempOutput.Location = new System.Drawing.Point(341, 177);
            this.txtTempOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempOutput.Name = "txtTempOutput";
            this.txtTempOutput.Size = new System.Drawing.Size(132, 22);
            this.txtTempOutput.TabIndex = 13;
            // 
            // btnBakim
            // 
            this.btnBakim.Location = new System.Drawing.Point(375, 15);
            this.btnBakim.Name = "btnBakim";
            this.btnBakim.Size = new System.Drawing.Size(112, 42);
            this.btnBakim.TabIndex = 14;
            this.btnBakim.Text = "Bakıma Ne Kadar Kaldı?";
            this.btnBakim.UseVisualStyleBackColor = true;
            this.btnBakim.Click += new System.EventHandler(this.btnBakim_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 229);
            this.Controls.Add(this.btnBakim);
            this.Controls.Add(this.txtTempOutput);
            this.Controls.Add(this.lblSuSicakligi);
            this.Controls.Add(this.btnGetCoolantTemp);
            this.Controls.Add(this.txtFuelOutput);
            this.Controls.Add(this.lblFuelLevel);
            this.Controls.Add(this.btnGetFuelLevel);
            this.Controls.Add(this.btnMyCar);
            this.Controls.Add(this.btnClearFaultCodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaultOutput);
            this.Controls.Add(this.BtnGetFaultCodes);
            this.Controls.Add(this.lblRpm);
            this.Controls.Add(this.txtRpmOutput);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Ana Ekran";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtRpmOutput;
        private System.Windows.Forms.Label lblRpm;
        private System.Windows.Forms.Button BtnGetFaultCodes;
        private System.Windows.Forms.TextBox txtFaultOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearFaultCodes;
        private System.Windows.Forms.Button btnMyCar;
        private System.Windows.Forms.Button btnGetFuelLevel;
        private System.Windows.Forms.Label lblFuelLevel;
        private System.Windows.Forms.TextBox txtFuelOutput;
        private System.Windows.Forms.Button btnGetCoolantTemp;
        private System.Windows.Forms.Label lblSuSicakligi;
        private System.Windows.Forms.TextBox txtTempOutput;
        private System.Windows.Forms.Button btnBakim;
    }
}