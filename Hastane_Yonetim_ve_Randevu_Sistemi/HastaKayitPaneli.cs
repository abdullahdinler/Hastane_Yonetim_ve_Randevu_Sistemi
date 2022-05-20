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
    public partial class HastaKayitPaneli : Form
    {
        public HastaKayitPaneli()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txttc.Text == "" || txtsifre.Text == "" || txtad.Text == "" || txtsoyad.Text == "")
            {
                MessageBox.Show("Eksik bilgi girisi yapilmistir. Bos alanlari doldurup tekrar deneyiniz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtad.Text = "";
                txtsoyad.Text = "";
                txttelefon.Text = "";
                cmbcinsiyet.Text = "";
                txttc.Text = "";
                txtsifre.Text = "";
            }
            else
            {

                SqlCommand comm = new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTel,HastaSifre,HastaCinsiyet) values (@ad,@soyad,@tc,@tel,@sifre,@cinsiyet)", sqlBaglanti.baglanti());
                comm.Parameters.AddWithValue("@ad", txtad.Text);
                comm.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                comm.Parameters.AddWithValue("@tel", txttelefon.Text);
                comm.Parameters.AddWithValue("@cinsiyet", cmbcinsiyet.Text);
                comm.Parameters.AddWithValue("@tc", txttc.Text);
                comm.Parameters.AddWithValue("@sifre", txtsifre.Text);
                comm.ExecuteNonQuery();
                sqlBaglanti.baglanti().Close();
                MessageBox.Show("Bilgileriniz kaydedilmiştir. Lütfen giriş bilgilerinizi bir yere not aliniz.", "Bilgilendime", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtad.Text = "";
                txtsoyad.Text = "";
                txttelefon.Text = "";
                cmbcinsiyet.Text = "";
                txttc.Text = "";
                txtsifre.Text = "";
            }
        }
    }
}
