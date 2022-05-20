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
    public partial class DoktorPanel : Form
    {
        public DoktorPanel()
        {
            InitializeComponent();
        }

        public string tc;
        private SqlBaglanti baglan = new SqlBaglanti();
        private void DoktorPanel_Load(object sender, EventArgs e)
        {
            // Giris yapan doktor bilgisi yazdirma.
            txttc.Text = tc;
            SqlCommand comm = new SqlCommand("Select DoktorAd,DoktorSoyad,DoktorBrans from Tbl_Doktorlar where DoktorTc = @tc",baglan.baglanti());
            comm.Parameters.AddWithValue("@tc", txttc.Text);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txadsoyad.Text = dr[0] + " " + dr[1];
                txtbrans.Text = dr[2].ToString();
            }



            // Randevu listesini DataGride yazdirma.

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where DoktorTc='" + txadsoyad.Text + "'",baglan.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rcbsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btn_randevuolustur_Click(object sender, EventArgs e)
        {
            DoktorRandevuOlustur ro = new DoktorRandevuOlustur();
            ro.tc = txttc.Text;
            ro.Show();
        }
    }
} 
