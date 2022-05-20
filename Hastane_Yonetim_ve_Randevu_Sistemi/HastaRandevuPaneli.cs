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
    public partial class HastaRandevuPaneli : Form
    {
        public HastaRandevuPaneli()
        {
            InitializeComponent();
        }

        public string tc;
        private SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private void HastaRandevuPaneli_Load(object sender, EventArgs e)
        {
            // Ad Soyad
            txttc.Text = tc;
            SqlCommand comm = new SqlCommand("select *from Tbl_Hastalar where HastaTc = @tc", sqlBaglanti.baglanti());
            comm.Parameters.AddWithValue("@tc", txttc.Text);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString() + " "+ dr[2].ToString();
            }
            sqlBaglanti.baglanti().Close();

            // Randevu Gecmisi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where HastaTc =" + tc, sqlBaglanti.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Brans
            SqlCommand comm2 = new SqlCommand("Select BransAd from Tbl_Branslar", sqlBaglanti.baglanti());
            SqlDataReader dr2 = comm2.ExecuteReader();
            while (dr2.Read())
            {
                combo_bolum.Items.Add(dr2[0].ToString());
            }
            sqlBaglanti.baglanti().Close();
        }

        private void combo_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_doktor.Items.Clear();
            SqlCommand comm = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @brans",sqlBaglanti.baglanti());
            comm.Parameters.AddWithValue("@brans", combo_bolum.Text);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                combo_doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            sqlBaglanti.baglanti().Close();
        }

        private void combo_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuId as [No], RandevuTarih as [Tarih], RandevuSaat as [Saa], DoktorTc as [Doktor Ad], RandevuDurum as [Durum] from Tbl_Randevular where RandevuBrans = '" + combo_bolum.Text  + "' and DoktorTc= '"+ combo_doktor.Text + "' and RandevuDurum = 0"  , sqlBaglanti.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lutfen aktif randevulardan birini seciniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Update Tbl_Randevular Set RandevuDurum = 1, HastaTc = @hastatc, RandevuSikayet = @sikayet where RandevuId= @id", sqlBaglanti.baglanti());
                cmd.Parameters.AddWithValue("@sikayet", richTextsikayet.Text);
                cmd.Parameters.AddWithValue("@hastatc", txttc.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();
                sqlBaglanti.baglanti().Close();
                MessageBox.Show("Randevu alinmistir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
