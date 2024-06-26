namespace CarCareProApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnGiris = new System.Windows.Forms.Button();
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.grpGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(163, 139);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 28);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // grpGiris
            // 
            this.grpGiris.Controls.Add(this.txtParola);
            this.grpGiris.Controls.Add(this.txtMail);
            this.grpGiris.Controls.Add(this.lblParola);
            this.grpGiris.Controls.Add(this.lblMail);
            this.grpGiris.Controls.Add(this.btnKayit);
            this.grpGiris.Controls.Add(this.btnGiris);
            this.grpGiris.Location = new System.Drawing.Point(16, 15);
            this.grpGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGiris.Size = new System.Drawing.Size(447, 233);
            this.grpGiris.TabIndex = 1;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "Kullanıcı Giriş Ekranı";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(147, 99);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(132, 22);
            this.txtParola.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(147, 64);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(132, 22);
            this.txtMail.TabIndex = 4;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(89, 102);
            this.lblParola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(50, 16);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(82, 67);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 16);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-posta:";
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(313, 23);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(100, 28);
            this.btnKayit.TabIndex = 1;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 265);
            this.Controls.Add(this.grpGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "CarCarePro ";
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.GroupBox grpGiris;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtParola;
    }
}

