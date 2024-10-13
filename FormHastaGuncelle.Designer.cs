namespace Hastane
{
    partial class FormHastaGuncelle
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
            this.label9 = new System.Windows.Forms.Label();
            this.TbxAdres = new System.Windows.Forms.TextBox();
            this.TbxMail = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TxbTel = new System.Windows.Forms.MaskedTextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.CbKontrol = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbSifre = new System.Windows.Forms.TextBox();
            this.RbKadın = new System.Windows.Forms.RadioButton();
            this.RbErkek = new System.Windows.Forms.RadioButton();
            this.TxbTc = new System.Windows.Forms.MaskedTextBox();
            this.TxbSoyad = new System.Windows.Forms.TextBox();
            this.TxbAd = new System.Windows.Forms.TextBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 58;
            this.label9.Text = "Adres:";
            // 
            // TbxAdres
            // 
            this.TbxAdres.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxAdres.Location = new System.Drawing.Point(232, 271);
            this.TbxAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxAdres.Name = "TbxAdres";
            this.TbxAdres.Size = new System.Drawing.Size(239, 40);
            this.TbxAdres.TabIndex = 57;
            this.TbxAdres.TextChanged += new System.EventHandler(this.TbxAdres_TextChanged);
            // 
            // TbxMail
            // 
            this.TbxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxMail.Location = new System.Drawing.Point(232, 368);
            this.TbxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxMail.Name = "TbxMail";
            this.TbxMail.Size = new System.Drawing.Size(239, 41);
            this.TbxMail.TabIndex = 55;
            this.TbxMail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TbxMail_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mail :";
            // 
            // DtDogumTarihi
            // 
            this.DtDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtDogumTarihi.Location = new System.Drawing.Point(232, 190);
            this.DtDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtDogumTarihi.Name = "DtDogumTarihi";
            this.DtDogumTarihi.Size = new System.Drawing.Size(171, 22);
            this.DtDogumTarihi.TabIndex = 54;
            this.DtDogumTarihi.Value = new System.DateTime(2024, 8, 13, 0, 0, 0, 0);
            this.DtDogumTarihi.ValueChanged += new System.EventHandler(this.DtDogumTarihi_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "Dogum Tarihi :";
            // 
            // TxbTel
            // 
            this.TxbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbTel.Location = new System.Drawing.Point(232, 319);
            this.TxbTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbTel.Mask = "(999) 000-0000";
            this.TxbTel.Name = "TxbTel";
            this.TxbTel.Size = new System.Drawing.Size(239, 41);
            this.TxbTel.TabIndex = 41;
            this.TxbTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxbTel_MaskInputRejected);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnGuncelle.Location = new System.Drawing.Point(290, 512);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(194, 58);
            this.BtnGuncelle.TabIndex = 52;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // CbKontrol
            // 
            this.CbKontrol.AutoSize = true;
            this.CbKontrol.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbKontrol.Location = new System.Drawing.Point(256, 475);
            this.CbKontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbKontrol.Name = "CbKontrol";
            this.CbKontrol.Size = new System.Drawing.Size(228, 33);
            this.CbKontrol.TabIndex = 51;
            this.CbKontrol.Text = "Ben Robot Değilim";
            this.CbKontrol.UseVisualStyleBackColor = true;
            this.CbKontrol.CheckedChanged += new System.EventHandler(this.CbKontrol_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tel No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ad :";
            // 
            // TxbSifre
            // 
            this.TxbSifre.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbSifre.Location = new System.Drawing.Point(232, 420);
            this.TxbSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbSifre.Name = "TxbSifre";
            this.TxbSifre.Size = new System.Drawing.Size(239, 40);
            this.TxbSifre.TabIndex = 44;
            this.TxbSifre.UseSystemPasswordChar = true;
            this.TxbSifre.TextChanged += new System.EventHandler(this.TxbSifre_TextChanged);
            // 
            // RbKadın
            // 
            this.RbKadın.AutoSize = true;
            this.RbKadın.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbKadın.Location = new System.Drawing.Point(339, 224);
            this.RbKadın.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbKadın.Name = "RbKadın";
            this.RbKadın.Size = new System.Drawing.Size(81, 28);
            this.RbKadın.TabIndex = 43;
            this.RbKadın.TabStop = true;
            this.RbKadın.Text = "Kadın";
            this.RbKadın.UseVisualStyleBackColor = true;
            // 
            // RbErkek
            // 
            this.RbErkek.AutoSize = true;
            this.RbErkek.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbErkek.Location = new System.Drawing.Point(232, 225);
            this.RbErkek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbErkek.Name = "RbErkek";
            this.RbErkek.Size = new System.Drawing.Size(79, 28);
            this.RbErkek.TabIndex = 42;
            this.RbErkek.TabStop = true;
            this.RbErkek.Text = "Erkek";
            this.RbErkek.UseVisualStyleBackColor = true;
            // 
            // TxbTc
            // 
            this.TxbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbTc.Location = new System.Drawing.Point(232, 122);
            this.TxbTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbTc.Mask = "00000000000";
            this.TxbTc.Name = "TxbTc";
            this.TxbTc.Size = new System.Drawing.Size(239, 41);
            this.TxbTc.TabIndex = 40;
            this.TxbTc.ValidatingType = typeof(int);
            this.TxbTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxbTc_MaskInputRejected);
            // 
            // TxbSoyad
            // 
            this.TxbSoyad.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbSoyad.Location = new System.Drawing.Point(232, 71);
            this.TxbSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbSoyad.Name = "TxbSoyad";
            this.TxbSoyad.Size = new System.Drawing.Size(239, 40);
            this.TxbSoyad.TabIndex = 39;
            this.TxbSoyad.TextChanged += new System.EventHandler(this.TxbSoyad_TextChanged);
            // 
            // TxbAd
            // 
            this.TxbAd.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbAd.Location = new System.Drawing.Point(232, 22);
            this.TxbAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbAd.Name = "TxbAd";
            this.TxbAd.Size = new System.Drawing.Size(239, 40);
            this.TxbAd.TabIndex = 38;
            this.TxbAd.TextChanged += new System.EventHandler(this.TxbAd_TextChanged);
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnCikis.Location = new System.Drawing.Point(33, 515);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(142, 53);
            this.BtnCikis.TabIndex = 59;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FormHastaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 571);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbxAdres);
            this.Controls.Add(this.TbxMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtDogumTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxbTel);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.CbKontrol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbSifre);
            this.Controls.Add(this.RbKadın);
            this.Controls.Add(this.RbErkek);
            this.Controls.Add(this.TxbTc);
            this.Controls.Add(this.TxbSoyad);
            this.Controls.Add(this.TxbAd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHastaGuncelle";
            this.Text = "FormHastaGuncelle";
            this.Load += new System.EventHandler(this.FormHastaGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxAdres;
        private System.Windows.Forms.MaskedTextBox TbxMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtDogumTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TxbTel;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.CheckBox CbKontrol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbSifre;
        private System.Windows.Forms.RadioButton RbKadın;
        private System.Windows.Forms.RadioButton RbErkek;
        private System.Windows.Forms.MaskedTextBox TxbTc;
        private System.Windows.Forms.TextBox TxbSoyad;
        private System.Windows.Forms.TextBox TxbAd;
        private System.Windows.Forms.Button BtnCikis;
    }
}