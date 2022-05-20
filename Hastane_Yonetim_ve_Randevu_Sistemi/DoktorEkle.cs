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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }

        private SqlBaglanti baglanti = new SqlBaglanti();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txttc.Text == "" || txtsifre.Text == "" || txtad.Text == "" || txtsoyad.Text == "" || txtbrans.Text == "")
            {
                MessageBox.Show("Eksik bilgi girisi yapildi doktor eklenmedi.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand comm = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTc, DoktorSifre) values (@ad, @soyad, @brans, @tc, @sifre)", baglanti.baglanti());
                comm.Parameters.AddWithValue("@ad", txtad.Text);
                comm.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                comm.Parameters.AddWithValue("@brans", txtbrans.Text);
                comm.Parameters.AddWithValue("@tc", txttc.Text);
                comm.Parameters.AddWithValue("@sifre", txtsifre.Text);
                comm.ExecuteNonQuery();
                baglanti.baglanti().Close();
                MessageBox.Show("Yeni doktor eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
