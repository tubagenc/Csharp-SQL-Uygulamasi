namespace SQLTest
{
    partial class Form1
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
            this.AdLabel = new System.Windows.Forms.Label();
            this.SoyadLabel = new System.Windows.Forms.Label();
            this.YasLabel = new System.Windows.Forms.Label();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.OnayLabel = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.Yas = new System.Windows.Forms.TextBox();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.Onay = new System.Windows.Forms.CheckBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.EkleButon = new System.Windows.Forms.Button();
            this.GuncelleButon = new System.Windows.Forms.Button();
            this.SilButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdLabel.Location = new System.Drawing.Point(12, 8);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(31, 23);
            this.AdLabel.TabIndex = 0;
            this.AdLabel.Text = "Ad";
            // 
            // SoyadLabel
            // 
            this.SoyadLabel.AutoSize = true;
            this.SoyadLabel.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadLabel.Location = new System.Drawing.Point(137, 8);
            this.SoyadLabel.Name = "SoyadLabel";
            this.SoyadLabel.Size = new System.Drawing.Size(56, 23);
            this.SoyadLabel.TabIndex = 1;
            this.SoyadLabel.Text = "Soyad";
            // 
            // YasLabel
            // 
            this.YasLabel.AutoSize = true;
            this.YasLabel.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YasLabel.Location = new System.Drawing.Point(261, 9);
            this.YasLabel.Name = "YasLabel";
            this.YasLabel.Size = new System.Drawing.Size(34, 23);
            this.YasLabel.TabIndex = 2;
            this.YasLabel.Text = "Yaş";
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihLabel.Location = new System.Drawing.Point(387, 9);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(48, 23);
            this.TarihLabel.TabIndex = 3;
            this.TarihLabel.Text = "Tarih";
            // 
            // OnayLabel
            // 
            this.OnayLabel.AutoSize = true;
            this.OnayLabel.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OnayLabel.Location = new System.Drawing.Point(520, 9);
            this.OnayLabel.Name = "OnayLabel";
            this.OnayLabel.Size = new System.Drawing.Size(49, 23);
            this.OnayLabel.TabIndex = 4;
            this.OnayLabel.Text = "Onay";
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(16, 34);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(116, 20);
            this.Ad.TabIndex = 5;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(141, 34);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(116, 20);
            this.Soyad.TabIndex = 6;
            // 
            // Yas
            // 
            this.Yas.Location = new System.Drawing.Point(265, 35);
            this.Yas.Name = "Yas";
            this.Yas.Size = new System.Drawing.Size(116, 20);
            this.Yas.TabIndex = 7;
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(391, 35);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(116, 20);
            this.Tarih.TabIndex = 8;
            // 
            // Onay
            // 
            this.Onay.AutoSize = true;
            this.Onay.Location = new System.Drawing.Point(535, 41);
            this.Onay.Name = "Onay";
            this.Onay.Size = new System.Drawing.Size(15, 14);
            this.Onay.TabIndex = 9;
            this.Onay.UseVisualStyleBackColor = true;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Location = new System.Drawing.Point(16, 79);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(793, 313);
            this.Liste.TabIndex = 10;
            // 
            // EkleButon
            // 
            this.EkleButon.Location = new System.Drawing.Point(575, 8);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.Size = new System.Drawing.Size(75, 47);
            this.EkleButon.TabIndex = 11;
            this.EkleButon.Text = "Ekle";
            this.EkleButon.UseVisualStyleBackColor = true;
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // GuncelleButon
            // 
            this.GuncelleButon.Location = new System.Drawing.Point(656, 9);
            this.GuncelleButon.Name = "GuncelleButon";
            this.GuncelleButon.Size = new System.Drawing.Size(75, 46);
            this.GuncelleButon.TabIndex = 12;
            this.GuncelleButon.Text = "Güncelle";
            this.GuncelleButon.UseVisualStyleBackColor = true;
            this.GuncelleButon.Click += new System.EventHandler(this.GuncelleButon_Click);
            // 
            // SilButon
            // 
            this.SilButon.Location = new System.Drawing.Point(737, 9);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(75, 46);
            this.SilButon.TabIndex = 13;
            this.SilButon.Text = "Sil";
            this.SilButon.UseVisualStyleBackColor = true;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 418);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.GuncelleButon);
            this.Controls.Add(this.EkleButon);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.Onay);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.Yas);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.OnayLabel);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.YasLabel);
            this.Controls.Add(this.SoyadLabel);
            this.Controls.Add(this.AdLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label SoyadLabel;
        private System.Windows.Forms.Label YasLabel;
        private System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Label OnayLabel;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox Yas;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.CheckBox Onay;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button EkleButon;
        private System.Windows.Forms.Button GuncelleButon;
        private System.Windows.Forms.Button SilButon;
    }
}

