
namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class DoktorBilgiDuzenleY
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtbrans = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_OtomasyonDataSet = new Hastane_Yonetim_ve_Randevu_Sistemi.Hastane_OtomasyonDataSet();
            this.tbl_DoktorlarTableAdapter = new Hastane_Yonetim_ve_Randevu_Sistemi.Hastane_OtomasyonDataSetTableAdapters.Tbl_DoktorlarTableAdapter();
            this.doktorSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_guncelle);
            this.groupBox2.Controls.Add(this.txttc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtsifre);
            this.groupBox2.Location = new System.Drawing.Point(336, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 172);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Giris Bilgisi";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guncelle.Location = new System.Drawing.Point(62, 121);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(180, 40);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Guncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(62, 37);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(180, 29);
            this.txttc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "T.c:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(62, 81);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(180, 29);
            this.txtsifre.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtbrans);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(47, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 172);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Genel Bilgisi";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(74, 34);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(160, 29);
            this.txtad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brans:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(74, 79);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(160, 29);
            this.txtsoyad.TabIndex = 7;
            // 
            // txtbrans
            // 
            this.txtbrans.Location = new System.Drawing.Point(75, 121);
            this.txtbrans.Name = "txtbrans";
            this.txtbrans.Size = new System.Drawing.Size(160, 29);
            this.txtbrans.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(47, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 198);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorAdDataGridViewTextBoxColumn,
            this.doktorSoyadDataGridViewTextBoxColumn,
            this.doktorBransDataGridViewTextBoxColumn,
            this.doktorTcDataGridViewTextBoxColumn,
            this.doktorSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDoktorlarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataMember = "Tbl_Doktorlar";
            this.tblDoktorlarBindingSource.DataSource = this.hastane_OtomasyonDataSet;
            // 
            // hastane_OtomasyonDataSet
            // 
            this.hastane_OtomasyonDataSet.DataSetName = "Hastane_OtomasyonDataSet";
            this.hastane_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DoktorlarTableAdapter
            // 
            this.tbl_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // doktorSifreDataGridViewTextBoxColumn
            // 
            this.doktorSifreDataGridViewTextBoxColumn.DataPropertyName = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.HeaderText = "DoktorSifre";
            this.doktorSifreDataGridViewTextBoxColumn.Name = "doktorSifreDataGridViewTextBoxColumn";
            // 
            // doktorTcDataGridViewTextBoxColumn
            // 
            this.doktorTcDataGridViewTextBoxColumn.DataPropertyName = "DoktorTc";
            this.doktorTcDataGridViewTextBoxColumn.HeaderText = "DoktorTc";
            this.doktorTcDataGridViewTextBoxColumn.Name = "doktorTcDataGridViewTextBoxColumn";
            // 
            // doktorBransDataGridViewTextBoxColumn
            // 
            this.doktorBransDataGridViewTextBoxColumn.DataPropertyName = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.HeaderText = "DoktorBrans";
            this.doktorBransDataGridViewTextBoxColumn.Name = "doktorBransDataGridViewTextBoxColumn";
            // 
            // doktorSoyadDataGridViewTextBoxColumn
            // 
            this.doktorSoyadDataGridViewTextBoxColumn.DataPropertyName = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.HeaderText = "DoktorSoyad";
            this.doktorSoyadDataGridViewTextBoxColumn.Name = "doktorSoyadDataGridViewTextBoxColumn";
            // 
            // doktorAdDataGridViewTextBoxColumn
            // 
            this.doktorAdDataGridViewTextBoxColumn.DataPropertyName = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.HeaderText = "DoktorAd";
            this.doktorAdDataGridViewTextBoxColumn.Name = "doktorAdDataGridViewTextBoxColumn";
            // 
            // DoktorBilgiDuzenleY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoktorBilgiDuzenleY";
            this.Text = "DoktorBilgiDuzenleY";
            this.Load += new System.EventHandler(this.DoktorBilgiDuzenleY_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_OtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtbrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hastane_OtomasyonDataSet hastane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private Hastane_OtomasyonDataSetTableAdapters.Tbl_DoktorlarTableAdapter tbl_DoktorlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSifreDataGridViewTextBoxColumn;
    }
}