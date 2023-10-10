using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasa_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double bakiye;

        private void btnYatir_Click(object sender, EventArgs e)
        {
            double yatirilacakTutar=Convert.ToDouble(txtTutar.Text);

            //bakiye = bakiye + yatirilacakTutar;
            bakiye += yatirilacakTutar;
            lblBakiye.Text = "Bakiye: " + bakiye.ToString() + " ₺";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bakiye = 0;
            lblBakiye.Text="Bakiye: "+bakiye.ToString()+" ₺";
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            double cekilecekTutar = Convert.ToDouble(txtTutar.Text);

            if(cekilecekTutar<=bakiye)
            {
                bakiye -= cekilecekTutar;
            }
            else
            {
                MessageBox.Show("YETERSİZ BAKİYE!!!");
            }



            
            lblBakiye.Text = "Bakiye: " + bakiye.ToString() + " ₺";
        }
    }
}
