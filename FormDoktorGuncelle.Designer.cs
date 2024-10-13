namespace Hastane
{
    partial class FormDoktorGuncelle
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
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxMail = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxbTel = new System.Windows.Forms.MaskedTextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.CbKontrol = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbSifre = new System.Windows.Forms.TextBox();
            this.TxbSoyad = new System.Windows.Forms.TextBox();
            this.TxbAd = new System.Windows.Forms.TextBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnCikis.Location = new System.Drawing.Point(33, 408);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(331, 53);
            this.BtnCikis.TabIndex = 81;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 80;
            this.label9.Text = "Branş:";
            // 
            // TbxMail
            // 
            this.TbxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxMail.Location = new System.Drawing.Point(232, 254);
            this.TbxMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxMail.Name = "TbxMail";
            this.TbxMail.Size = new System.Drawing.Size(502, 41);
            this.TbxMail.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 78;
            this.label8.Text = "Mail :";
            // 
            // TxbTel
            // 
            this.TxbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbTel.Location = new System.Drawing.Point(232, 205);
            this.TxbTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbTel.Mask = "(999) 000-0000";
            this.TxbTel.Name = "TxbTel";
            this.TxbTel.Size = new System.Drawing.Size(502, 41);
            this.TxbTel.TabIndex = 63;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnGuncelle.Location = new System.Drawing.Point(403, 405);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(331, 58);
            this.BtnGuncelle.TabIndex = 74;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // CbKontrol
            // 
            this.CbKontrol.AutoSize = true;
            this.CbKontrol.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbKontrol.Location = new System.Drawing.Point(506, 368);
            this.CbKontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbKontrol.Name = "CbKontrol";
            this.CbKontrol.Size = new System.Drawing.Size(228, 33);
            this.CbKontrol.TabIndex = 73;
            this.CbKontrol.Text = "Ben Robot Değilim";
            this.CbKontrol.UseVisualStyleBackColor = true;
            this.CbKontrol.CheckedChanged += new System.EventHandler(this.CbKontrol_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 29);
            this.label6.TabIndex = 71;
            this.label6.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Tel No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "Ad :";
            // 
            // TxbSifre
            // 
            this.TxbSifre.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbSifre.Location = new System.Drawing.Point(232, 306);
            this.TxbSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbSifre.Name = "TxbSifre";
            this.TxbSifre.Size = new System.Drawing.Size(502, 40);
            this.TxbSifre.TabIndex = 66;
            this.TxbSifre.UseSystemPasswordChar = true;
            // 
            // TxbSoyad
            // 
            this.TxbSoyad.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbSoyad.Location = new System.Drawing.Point(232, 85);
            this.TxbSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbSoyad.Name = "TxbSoyad";
            this.TxbSoyad.Size = new System.Drawing.Size(502, 40);
            this.TxbSoyad.TabIndex = 61;
            // 
            // TxbAd
            // 
            this.TxbAd.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxbAd.Location = new System.Drawing.Point(232, 36);
            this.TxbAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbAd.Name = "TxbAd";
            this.TxbAd.Size = new System.Drawing.Size(502, 40);
            this.TxbAd.TabIndex = 60;
            // 
            // CmbBrans
            // 
            this.CmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(232, 147);
            this.CmbBrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(502, 44);
            this.CmbBrans.TabIndex = 82;
            // 
            // FormDoktorGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 489);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbxMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxbTel);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.CbKontrol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbSifre);
            this.Controls.Add(this.TxbSoyad);
            this.Controls.Add(this.TxbAd);
            this.Name = "FormDoktorGuncelle";
            this.Text = "FormDoktorGuncelle";
            this.Load += new System.EventHandler(this.FormDoktorGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox TbxMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TxbTel;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.CheckBox CbKontrol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbSifre;
        private System.Windows.Forms.TextBox TxbSoyad;
        private System.Windows.Forms.TextBox TxbAd;
        private System.Windows.Forms.ComboBox CmbBrans;
    }
}