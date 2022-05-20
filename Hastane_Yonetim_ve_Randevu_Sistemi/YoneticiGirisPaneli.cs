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
    public partial class YoneticiGirisPaneli : Form
    {
        public YoneticiGirisPaneli()
        {
            InitializeComponent();
        }

        private SqlBaglanti baglanti = new SqlBaglanti();
        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Tbl_Yoneticiler where YoneticiTc = @tc and YoneticiSifre = @sifre", baglanti.baglanti());
            comm.Parameters.AddWithValue("@tc", txttc.Text);
            comm.Parameters.AddWithValue("@sifre", txtsifre.Text);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
                yoneticiPaneli.tc = txttc.Text;
                yoneticiPaneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Hatlı Tc veya Şifre.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttc.Text = "";
                txtsifre.Text = "";
            }

        }
    }
}
