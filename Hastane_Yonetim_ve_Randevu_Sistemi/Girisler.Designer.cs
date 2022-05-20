
namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class Girisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girisler));
            this.btn_hasta = new System.Windows.Forms.Button();
            this.btn_doktor = new System.Windows.Forms.Button();
            this.btn_yonetici = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hasta
            // 
            this.btn_hasta.BackColor = System.Drawing.Color.DarkRed;
            this.btn_hasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hasta.BackgroundImage")));
            this.btn_hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hasta.Location = new System.Drawing.Point(43, 227);
            this.btn_hasta.Name = "btn_hasta";
            this.btn_hasta.Size = new System.Drawing.Size(153, 160);
            this.btn_hasta.TabIndex = 0;
            this.btn_hasta.UseVisualStyleBackColor = false;
            this.btn_hasta.Click += new System.EventHandler(this.btn_hasta_Click);
            // 
            // btn_doktor
            // 
            this.btn_doktor.BackColor = System.Drawing.Color.DarkRed;
            this.btn_doktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktor.BackgroundImage")));
            this.btn_doktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktor.Location = new System.Drawing.Point(246, 227);
            this.btn_doktor.Name = "btn_doktor";
            this.btn_doktor.Size = new System.Drawing.Size(153, 160);
            this.btn_doktor.TabIndex = 1;
            this.btn_doktor.UseVisualStyleBackColor = false;
            this.btn_doktor.Click += new System.EventHandler(this.btn_doktor_Click);
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.BackColor = System.Drawing.Color.DarkRed;
            this.btn_yonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yonetici.BackgroundImage")));
            this.btn_yonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yonetici.Location = new System.Drawing.Point(448, 227);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(153, 160);
            this.btn_yonetici.TabIndex = 2;
            this.btn_yonetici.UseVisualStyleBackColor = false;
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(283, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(480, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yonetici";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_yonetici);
            this.Controls.Add(this.btn_doktor);
            this.Controls.Add(this.btn_hasta);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Girisler";
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hasta;
        private System.Windows.Forms.Button btn_doktor;
        private System.Windows.Forms.Button btn_yonetici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

