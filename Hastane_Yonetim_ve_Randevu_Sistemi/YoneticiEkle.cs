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
    public partial class YoneticiEkle : Form
    {
        public YoneticiEkle()
        {
            InitializeComponent();
        }

        private SqlBaglanti baglanti = new SqlBaglanti();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txttc.Text == "" || txtad.Text == "" || txtsifre.Text == "" || txtsoyad.Text == "" )
            {
                MessageBox.Show("Eksik bilgi girisi yapildi. Lutfen bos alanlari doldurunuz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand comm = new SqlCommand("insert into Tbl_Yoneticiler (YoneticiAd, YoneticiSoyad, YoneticiTc, YoneticiSifre) values (@ad, @soyad, @tc, @sifre)", baglanti.baglanti());
                comm.Parameters.AddWithValue("@ad", txtad.Text);
                comm.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                comm.Parameters.AddWithValue("@tc", txttc.Text);
                comm.Parameters.AddWithValue("@sifre", txtsifre.Text);
                comm.ExecuteNonQuery();
                baglanti.baglanti().Close();
                MessageBox.Show("Yeni yonetici eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
