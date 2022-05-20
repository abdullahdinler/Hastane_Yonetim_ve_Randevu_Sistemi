using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    public partial class DoktorBilgiDuzenleY : Form
    {
        public DoktorBilgiDuzenleY()
        {
            InitializeComponent();
        }

        private void DoktorBilgiDuzenleY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastane_OtomasyonDataSet.Tbl_Doktorlar' table. You can move, or remove it, as needed.
            this.tbl_DoktorlarTableAdapter.Fill(this.hastane_OtomasyonDataSet.Tbl_Doktorlar);

        }

        private SqlBaglanti komut = new SqlBaglanti();
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Data Gride cift tikladigi zaman icindeki bilgileri tetxt boxa at.
            string ad, soyad, brans, tc, sifre;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            brans = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtad.Text = ad;
            txtsoyad.Text = soyad;
            txtbrans.Text = brans;
            txttc.Text = tc;
            txtsifre.Text = sifre;

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txttc.Text == "")
            {
                MessageBox.Show("Lutfen doktorlardan birini secerek guncelleme yapiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand comm = new SqlCommand("Update Tbl_Doktorlar set DoktorAd = @ad, DoktorSoyad = @soyad, DoktorBrans = @brans, DoktorTc = @tc, DoktorSifre = @sifre where DoktorTc = @tc", komut.baglanti());
                //comm.Parameters.AddWithValue("@id",id)
                comm.Parameters.AddWithValue("@ad", txtad.Text);
                comm.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                comm.Parameters.AddWithValue("@brans", txtbrans.Text);
                comm.Parameters.AddWithValue("@tc", txttc.Text);
                comm.Parameters.AddWithValue("@sifre", txtsifre.Text);
                comm.ExecuteNonQuery();
                komut.baglanti().Close();
                MessageBox.Show("Doktor bilgisi guncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtad.Text = "";
                txtsoyad.Text = "";
                txtbrans.Text = "";
                txttc.Text = "";
                txtsifre.Text = "";
            }
        }

    }
}
