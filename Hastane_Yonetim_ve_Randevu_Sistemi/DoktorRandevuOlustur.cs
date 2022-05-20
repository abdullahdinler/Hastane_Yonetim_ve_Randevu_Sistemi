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
    public partial class DoktorRandevuOlustur : Form
    {
        public DoktorRandevuOlustur()
        {
            InitializeComponent();
        }

        public string tc;
        private SqlBaglanti bag = new SqlBaglanti();
        private void DoktorRandevuOlustur_Load(object sender, EventArgs e)
        {
            txtdoktortc.Text = tc;
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad,DoktorBrans from Tbl_Doktorlar where DoktorTc = @tc", bag.baglanti());
            cmd.Parameters.AddWithValue("@tc", txtdoktortc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtadsoyad.Text = dr[0] + " " + dr[1];
                txtbrans.Text = dr[2].ToString();
            }
        }

        private void btn_randevuolustur_Click(object sender, EventArgs e)
        {
            if (mtb_tarih.Text == "  /  /" || mtb_saat.Text == "  :")
            {
                MessageBox.Show("lutfen randevu tarihi ve saatini doldurunuz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else  
            {
                SqlCommand cmd2 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,DoktorTc) values (@tarih,@saat,@brans,@doktoradsoyad)", bag.baglanti());
                cmd2.Parameters.AddWithValue("@tarih", mtb_tarih.Text);
                cmd2.Parameters.AddWithValue("@saat", mtb_saat.Text);
                cmd2.Parameters.AddWithValue("@brans", txtbrans.Text);
                cmd2.Parameters.AddWithValue("@doktoradsoyad", txtadsoyad.Text);
                cmd2.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Randevu eklendi.", "Bilgilendime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
