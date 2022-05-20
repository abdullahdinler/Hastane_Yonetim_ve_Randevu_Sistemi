using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    public partial class Girisler : Form
    {
        public Girisler()
        {
            InitializeComponent();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            HastaGirisPaneli hastaGiris = new HastaGirisPaneli();
            hastaGiris.Show();
            this.Hide();
            

        }

        private void btn_doktor_Click(object sender, EventArgs e)
        {
            DoktorGirisPaneli doktorGiris = new DoktorGirisPaneli();
            doktorGiris.Show();
            this.Hide();
        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            YoneticiGirisPaneli yoneticiGiris = new YoneticiGirisPaneli();
            yoneticiGiris.Show();
            this.Hide();
        }
    }
}
