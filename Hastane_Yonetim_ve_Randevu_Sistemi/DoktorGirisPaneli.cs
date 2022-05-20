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
    public partial class DoktorGirisPaneli : Form
    {
        public DoktorGirisPaneli()
        {
            InitializeComponent();
        }

        private SqlBaglanti baglan = new SqlBaglanti();
        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTc = @tc and DoktorSifre = @sifre", baglan.baglanti());
            comm.Parameters.AddWithValue("@tc", txttc.Text);
            comm.Parameters.AddWithValue("@sifre", txtsifre.Text);
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                DoktorPanel doktorPanel = new DoktorPanel();
                doktorPanel.tc = txttc.Text;
                doktorPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Hatlı Tc veya Şifre.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txttc.Text = "";
            txtsifre.Text = "";
        }
    }
}
