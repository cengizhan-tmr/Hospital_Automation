namespace Hastane
{
    partial class FormHastaKayıt
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
            this.TxbTel = new System.Windows.Forms.MaskedTextBox();
            this.BtnKayıt = new System.Windows.Forms.Button();
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
            this.label7 = new System.Windows.Forms.Label();
            this.DtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.TbxMail = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxAdres = new System.Windows.Forms.TextBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxbTel
            // 
            this.TxbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbTel.Location = new System.Drawing.Point(233, 327);
            this.TxbTel.Mask = "(999) 000-0000";
            this.TxbTel.Name = "TxbTel";
            this.TxbTel.Size = new System.Drawing.Size(540, 41);
            this.TxbTel.TabIndex = 19;
            // 
            // BtnKayıt
            // 
            this.BtnKayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayıt.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnKayıt.Location = new System.Drawing.Point(481, 513);
            this.BtnKayıt.Name = "BtnKayıt";
            this.BtnKayıt.Size = new System.Drawing.Size(292, 58);
            this.BtnKayıt.TabIndex = 30;
            this.BtnKayıt.Text = "Kayıt Ol";
            this.BtnKayıt.UseVisualStyleBackColor = false;
            this.BtnKayıt.Click += new System.EventHandler(this.BtnKayıt_Click);
            // 
            // CbKontrol
            // 
            this.CbKontrol.AutoSize = true;
            this.CbKontrol.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbKontrol.Location = new System.Drawing.Point(545, 474);
            this.CbKontrol.Name = "CbKontrol";
            this.CbKontrol.Size = new System.Drawing.Size(228, 33);
            this.CbKontrol.TabIndex = 29;
            this.CbKontrol.Text = "Ben Robot Değilim";
            this.CbKontrol.UseVisualStyleBackColor = true;
            this.CbKontrol.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cinsiyet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tel No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad :";
            // 
            // TxbSifre
            // 
            this.TxbSifre.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbSifre.Location = new System.Drawing.Point(233, 428);
            this.TxbSifre.Name = "TxbSifre";
            this.TxbSifre.Size = new System.Drawing.Size(540, 40);
            this.TxbSifre.TabIndex = 22;
            this.TxbSifre.UseSystemPasswordChar = true;
            // 
            // RbKadın
            // 
            this.RbKadın.AutoSize = true;
            this.RbKadın.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbKadın.Location = new System.Drawing.Point(345, 233);
            this.RbKadın.Name = "RbKadın";
            this.RbKadın.Size = new System.Drawing.Size(81, 28);
            this.RbKadın.TabIndex = 21;
            this.RbKadın.TabStop = true;
            this.RbKadın.Text = "Kadın";
            this.RbKadın.UseVisualStyleBackColor = true;
            // 
            // RbErkek
            // 
            this.RbErkek.AutoSize = true;
            this.RbErkek.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbErkek.Location = new System.Drawing.Point(233, 234);
            this.RbErkek.Name = "RbErkek";
            this.RbErkek.Size = new System.Drawing.Size(79, 28);
            this.RbErkek.TabIndex = 20;
            this.RbErkek.TabStop = true;
            this.RbErkek.Text = "Erkek";
            this.RbErkek.UseVisualStyleBackColor = true;
            // 
            // TxbTc
            // 
            this.TxbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbTc.Location = new System.Drawing.Point(233, 131);
            this.TxbTc.Mask = "00000000000";
            this.TxbTc.Name = "TxbTc";
            this.TxbTc.Size = new System.Drawing.Size(540, 41);
            this.TxbTc.TabIndex = 18;
            this.TxbTc.ValidatingType = typeof(int);
            // 
            // TxbSoyad
            // 
            this.TxbSoyad.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbSoyad.Location = new System.Drawing.Point(233, 80);
            this.TxbSoyad.Name = "TxbSoyad";
            this.TxbSoyad.Size = new System.Drawing.Size(540, 40);
            this.TxbSoyad.TabIndex = 17;
            // 
            // TxbAd
            // 
            this.TxbAd.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbAd.Location = new System.Drawing.Point(233, 31);
            this.TxbAd.Name = "TxbAd";
            this.TxbAd.Size = new System.Drawing.Size(540, 40);
            this.TxbAd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(29, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Dogum Tarihi :";
            // 
            // DtDogumTarihi
            // 
            this.DtDogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtDogumTarihi.Location = new System.Drawing.Point(233, 198);
            this.DtDogumTarihi.Name = "DtDogumTarihi";
            this.DtDogumTarihi.Size = new System.Drawing.Size(540, 22);
            this.DtDogumTarihi.TabIndex = 33;
            // 
            // TbxMail
            // 
            this.TbxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxMail.Location = new System.Drawing.Point(233, 377);
            this.TbxMail.Name = "TbxMail";
            this.TbxMail.Size = new System.Drawing.Size(540, 41);
            this.TbxMail.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mail :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(29, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "Adres:";
            // 
            // TbxAdres
            // 
            this.TbxAdres.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxAdres.Location = new System.Drawing.Point(233, 279);
            this.TbxAdres.Name = "TbxAdres";
            this.TbxAdres.Size = new System.Drawing.Size(540, 40);
            this.TbxAdres.TabIndex = 36;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnCikis.Location = new System.Drawing.Point(233, 513);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(242, 58);
            this.BtnCikis.TabIndex = 38;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FormHastaKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbxAdres);
            this.Controls.Add(this.TbxMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtDogumTarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxbTel);
            this.Controls.Add(this.BtnKayıt);
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
            this.Name = "FormHastaKayıt";
            this.Text = "FormHastaKayıt";
            this.Load += new System.EventHandler(this.FormHastaKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxbTel;
        private System.Windows.Forms.Button BtnKayıt;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtDogumTarihi;
        private System.Windows.Forms.MaskedTextBox TbxMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbxAdres;
        private System.Windows.Forms.Button BtnCikis;
    }
}