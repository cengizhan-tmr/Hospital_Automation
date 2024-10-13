namespace Hastane
{
    partial class FormKontrol
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
            this.Btn_Kontrol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Kontrol = new System.Windows.Forms.Label();
            this.Tbx_Kotrol = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Kontrol
            // 
            this.Btn_Kontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Btn_Kontrol.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Kontrol.Location = new System.Drawing.Point(21, 224);
            this.Btn_Kontrol.Name = "Btn_Kontrol";
            this.Btn_Kontrol.Size = new System.Drawing.Size(259, 64);
            this.Btn_Kontrol.TabIndex = 7;
            this.Btn_Kontrol.Text = "Tıkla";
            this.Btn_Kontrol.UseVisualStyleBackColor = false;
            this.Btn_Kontrol.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 45);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(78, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ben Robot Değilim !";
            // 
            // Lbl_Kontrol
            // 
            this.Lbl_Kontrol.AutoSize = true;
            this.Lbl_Kontrol.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Kontrol.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Kontrol.Location = new System.Drawing.Point(49, 57);
            this.Lbl_Kontrol.Name = "Lbl_Kontrol";
            this.Lbl_Kontrol.Size = new System.Drawing.Size(179, 80);
            this.Lbl_Kontrol.TabIndex = 6;
            this.Lbl_Kontrol.Text = "NULL";
            // 
            // Tbx_Kotrol
            // 
            this.Tbx_Kotrol.BackColor = System.Drawing.Color.White;
            this.Tbx_Kotrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbx_Kotrol.ForeColor = System.Drawing.Color.Black;
            this.Tbx_Kotrol.Location = new System.Drawing.Point(63, 161);
            this.Tbx_Kotrol.Name = "Tbx_Kotrol";
            this.Tbx_Kotrol.Size = new System.Drawing.Size(165, 57);
            this.Tbx_Kotrol.TabIndex = 5;
            // 
            // FormKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 316);
            this.Controls.Add(this.Btn_Kontrol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_Kontrol);
            this.Controls.Add(this.Tbx_Kotrol);
            this.Name = "FormKontrol";
            this.Text = "FormKontrol";
            this.Load += new System.EventHandler(this.FormKontrol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Kontrol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Kontrol;
        private System.Windows.Forms.TextBox Tbx_Kotrol;
    }
}