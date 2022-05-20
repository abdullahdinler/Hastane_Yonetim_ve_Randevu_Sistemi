
namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class DoktorRandevuOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorRandevuOlustur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_tarih = new System.Windows.Forms.MaskedTextBox();
            this.mtb_saat = new System.Windows.Forms.MaskedTextBox();
            this.txtbrans = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.btn_randevuolustur = new System.Windows.Forms.Button();
            this.txtdoktortc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brans:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saat:";
            // 
            // mtb_tarih
            // 
            this.mtb_tarih.Location = new System.Drawing.Point(150, 29);
            this.mtb_tarih.Mask = "00/00/0000";
            this.mtb_tarih.Name = "mtb_tarih";
            this.mtb_tarih.Size = new System.Drawing.Size(168, 29);
            this.mtb_tarih.TabIndex = 4;
            this.mtb_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_saat
            // 
            this.mtb_saat.Location = new System.Drawing.Point(150, 71);
            this.mtb_saat.Mask = "00:00";
            this.mtb_saat.Name = "mtb_saat";
            this.mtb_saat.Size = new System.Drawing.Size(168, 29);
            this.mtb_saat.TabIndex = 5;
            this.mtb_saat.ValidatingType = typeof(System.DateTime);
            // 
            // txtbrans
            // 
            this.txtbrans.Enabled = false;
            this.txtbrans.Location = new System.Drawing.Point(150, 111);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(168, 29);
            this.txtbrans.TabIndex = 6;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Enabled = false;
            this.txtadsoyad.Location = new System.Drawing.Point(150, 149);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(168, 29);
            this.txtadsoyad.TabIndex = 7;
            // 
            // btn_randevuolustur
            // 
            this.btn_randevuolustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_randevuolustur.Location = new System.Drawing.Point(150, 219);
            this.btn_randevuolustur.Name = "btn_randevuolustur";
            this.btn_randevuolustur.Size = new System.Drawing.Size(168, 45);
            this.btn_randevuolustur.TabIndex = 8;
            this.btn_randevuolustur.Text = "Randevu Olustur";
            this.btn_randevuolustur.UseVisualStyleBackColor = false;
            this.btn_randevuolustur.Click += new System.EventHandler(this.btn_randevuolustur_Click);
            // 
            // txtdoktortc
            // 
            this.txtdoktortc.Enabled = false;
            this.txtdoktortc.Location = new System.Drawing.Point(150, 184);
            this.txtdoktortc.Name = "txtdoktortc";
            this.txtdoktortc.Size = new System.Drawing.Size(168, 29);
            this.txtdoktortc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doktor T.C:";
            // 
            // DoktorRandevuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 301);
            this.Controls.Add(this.txtdoktortc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_randevuolustur);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txtbrans);
            this.Controls.Add(this.mtb_saat);
            this.Controls.Add(this.mtb_tarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DoktorRandevuOlustur";
            this.Text = "Doktor Randevu Olustur";
            this.Load += new System.EventHandler(this.DoktorRandevuOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtb_tarih;
        private System.Windows.Forms.MaskedTextBox mtb_saat;
        private System.Windows.Forms.TextBox txtbrans;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Button btn_randevuolustur;
        private System.Windows.Forms.TextBox txtdoktortc;
        private System.Windows.Forms.Label label5;
    }
}