
namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class YoneticiGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisPaneli));
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yoneticiekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_girisyap.Location = new System.Drawing.Point(125, 305);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(154, 43);
            this.btn_girisyap.TabIndex = 21;
            this.btn_girisyap.Text = "Giris Yap";
            this.btn_girisyap.UseVisualStyleBackColor = false;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(125, 259);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(154, 29);
            this.txtsifre.TabIndex = 20;
            this.txtsifre.Text = "yonetici1";
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(125, 214);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(154, 29);
            this.txttc.TabIndex = 19;
            this.txttc.Text = "99999999999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(62, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sifre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "T.c:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Yonetici Girs Paneli";
            // 
            // btn_yoneticiekle
            // 
            this.btn_yoneticiekle.BackColor = System.Drawing.Color.DarkRed;
            this.btn_yoneticiekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yoneticiekle.BackgroundImage")));
            this.btn_yoneticiekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yoneticiekle.Location = new System.Drawing.Point(125, 26);
            this.btn_yoneticiekle.Name = "btn_yoneticiekle";
            this.btn_yoneticiekle.Size = new System.Drawing.Size(134, 130);
            this.btn_yoneticiekle.TabIndex = 22;
            this.btn_yoneticiekle.UseVisualStyleBackColor = false;
            // 
            // YoneticiGirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 388);
            this.Controls.Add(this.btn_yoneticiekle);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YoneticiGirisPaneli";
            this.Text = "YoneticiGirisPaneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_yoneticiekle;
    }
}