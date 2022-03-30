using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cıkısYap_Click(object sender, EventArgs e)
        {
           DialogResult sonuc = MessageBox.Show("çıkış yapmak istiyor musunuz ? ", "Bilgilendirme ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(sonuc==DialogResult.Yes)
            {
                lbl_sonuc.Text = "çıkış yapılıyor";

            }
            else
            {
                lbl_sonuc.Text = "çıkış yapılamadı!";
            }
        }
    }
}
