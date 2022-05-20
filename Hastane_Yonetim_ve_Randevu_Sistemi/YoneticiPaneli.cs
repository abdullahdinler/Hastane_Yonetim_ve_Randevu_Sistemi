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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void btn_doktorekle_Click(object sender, EventArgs e)
        {
            DoktorEkle doktorEkle = new DoktorEkle();
            doktorEkle.Show();
 
        }

        private void btn_doktorduzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenleY doktorBilgiDuzenleY = new DoktorBilgiDuzenleY();
            doktorBilgiDuzenleY.Show();

        }

        private void btn_yoneticiekle_Click(object sender, EventArgs e)
        {
            YoneticiEkle yoneticiEkle = new YoneticiEkle();
            yoneticiEkle.Show();

        }

        public string tc;
        private SqlBaglanti baglanti = new SqlBaglanti();
        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            txttc.Text = tc;
            SqlCommand comm = new SqlCommand("Select YoneticiAd,YoneticiSoyad from Tbl_Yoneticiler where YoneticiTc = @tc",baglanti.baglanti());
            comm.Parameters.AddWithValue("@tc", txttc.Text);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txtadsoyad.Text = dr[0] + " " + dr[1];
            }
        }
    }
}
