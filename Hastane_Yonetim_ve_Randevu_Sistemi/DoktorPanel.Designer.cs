
namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class DoktorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbrans = new System.Windows.Forms.Label();
            this.txadsoyad = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rcbsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_randevuolustur = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbrans);
            this.groupBox1.Controls.Add(this.txadsoyad);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgisi";
            // 
            // txtbrans
            // 
            this.txtbrans.AutoSize = true;
            this.txtbrans.Location = new System.Drawing.Point(94, 94);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(40, 22);
            this.txtbrans.TabIndex = 5;
            this.txtbrans.Text = "Null";
            // 
            // txadsoyad
            // 
            this.txadsoyad.AutoSize = true;
            this.txadsoyad.Location = new System.Drawing.Point(94, 61);
            this.txadsoyad.Name = "txadsoyad";
            this.txadsoyad.Size = new System.Drawing.Size(40, 22);
            this.txadsoyad.TabIndex = 4;
            this.txadsoyad.Text = "Null";
            // 
            // txttc
            // 
            this.txttc.AutoSize = true;
            this.txttc.Location = new System.Drawing.Point(94, 25);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(40, 22);
            this.txttc.TabIndex = 3;
            this.txttc.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brans:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rcbsikayet);
            this.groupBox2.Location = new System.Drawing.Point(13, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rcbsikayet
            // 
            this.rcbsikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcbsikayet.Location = new System.Drawing.Point(3, 25);
            this.rcbsikayet.Name = "rcbsikayet";
            this.rcbsikayet.Size = new System.Drawing.Size(268, 220);
            this.rcbsikayet.TabIndex = 0;
            this.rcbsikayet.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(289, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(619, 469);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_randevuolustur
            // 
            this.btn_randevuolustur.BackColor = System.Drawing.Color.Teal;
            this.btn_randevuolustur.Location = new System.Drawing.Point(13, 431);
            this.btn_randevuolustur.Name = "btn_randevuolustur";
            this.btn_randevuolustur.Size = new System.Drawing.Size(271, 48);
            this.btn_randevuolustur.TabIndex = 4;
            this.btn_randevuolustur.Text = "Randevu Olustur";
            this.btn_randevuolustur.UseVisualStyleBackColor = false;
            this.btn_randevuolustur.Click += new System.EventHandler(this.btn_randevuolustur_Click);
            // 
            // DoktorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 509);
            this.Controls.Add(this.btn_randevuolustur);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorPanel";
            this.Text = "Doktor Panel";
            this.Load += new System.EventHandler(this.DoktorPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtbrans;
        private System.Windows.Forms.Label txadsoyad;
        private System.Windows.Forms.Label txttc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rcbsikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_randevuolustur;
    }
}